-- Creacion de la db
CREATE DATABASE car_care;

USE car_care;
-- TABLA VEHICULOS
CREATE TABLE vehiculos(id_vehiculos INT PRIMARY KEY AUTO_INCREMENT, marca VARCHAR(150), modelo VARCHAR(150), tipo_vehiculo VARCHAR(150));

-- TABLA RUTINAS
CREATE TABLE rutinas(id_rutinas INT PRIMARY KEY AUTO_INCREMENT,nombre VARCHAR(150),descripcion VARCHAR(255));

-- CRUD DE RUTINAS.
-- INSERTAR y EDITAR
delimiter ;;
CREATE PROCEDURE insertar_rutinas(IN _nombre VARCHAR(150), IN _descripcion VARCHAR(255), _id_rutinas INT )
BEGIN
	DECLARE x INT;
	SELECT COUNT(*) FROM rutinas WHERE nombre = _nombre INTO x;
	IF x = 0 AND _id_rutinas < 0 then
	INSERT INTO rutinas VALUES (NULL,_nombre,_descripcion);
	ELSE IF x = 0 AND _id_rutinas > 0 then
	UPDATE rutinas SET nombre = _nombre, descripcion = _descripcion WHERE id_rutinas = _id_rutinas;
	ELSE
	UPDATE rutinas SET descripcion = _descripcion WHERE id_rutinas = _id_rutinas;
	END if;
	END if;
END;;


-- BORRAR
delimiter ;;
CREATE PROCEDURE borrar_rutinas(IN _id_rutinas INT)
BEGIN
	DELETE FROM rutinas r WHERE r.id_rutinas = _id_rutinas;
END;;

-- MOSTRAR
DROP PROCEDURE IF EXISTS mostrar_rutinas;
delimiter ;;
CREATE PROCEDURE mostrar_rutinas (IN filtro VARCHAR(50))
BEGIN
	SELECT r.nombre AS 'Nombre de la rutina', r.descripcion AS 'Descripción de la rutina'  FROM rutinas r WHERE nombre LIKE filtro ORDER BY id_rutinas;
END;;


-- ------------------------------------------------------------------------------------------------------
-- TABLA PROGRAMACION DE RUTINAS
CREATE TABLE programar_rutinas(id_rut_programadas INT PRIMARY KEY AUTO_INCREMENT, fk_id_vehiculos INT,
fk_id_rutinas int, fecha VARCHAR(150),
FOREIGN KEY (fk_id_vehiculos) REFERENCES vehiculos (id_vehiculos),
FOREIGN KEY (fk_id_rutinas) REFERENCES rutinas (id_rutinas));



-- CRUD DE PROGRAMACION DE RUTINAS.
-- INSERTAR y EDITAR
DROP PROCEDURE IF EXISTS insertar_rutinas_programadas
delimiter ;;
CREATE PROCEDURE insertar_rutinas_programadas(IN _fk_id_vehiculos INT, IN _fk_id_rutinas INT, IN _fecha VARCHAR(255), IN _id_rut_programadas INT )
BEGIN
	DECLARE x INT;
	SELECT COUNT(*) FROM programar_rutinas pr WHERE pr.fk_id_vehiculos = _fk_id_vehiculos INTO x;
	IF x = 0 AND _id_rut_programadas < 0 then
	INSERT INTO programar_rutinas  VALUES (NULL,_fk_id_vehiculos,_fk_id_rutinas,_fecha);
	ELSE IF x = 0 AND _id_rut_programadas > 0 then
	UPDATE programar_rutinas pr SET pr.fk_id_vehiculos = _fk_id_vehiculos, pr.fk_id_rutinas = _fk_id_rutinas, pr.fecha = _fecha WHERE pr.id_rut_programadas = _id_rut_programadas;
	ELSE
	UPDATE programar_rutinas pr SET pr.fk_id_rutinas = _fk_id_rutinas, pr.fecha = _fecha WHERE pr.id_rut_programadas = _id_rut_programadas;
	END if;
	END if;
END;;


-- BORRAR
delimiter ;;
CREATE PROCEDURE borrar_rutinas_programadas(IN _id_rutinas INT)
BEGIN
	DELETE FROM programar_rutinas r WHERE r.id_rut_programadas = _id_rutinas;
END;;

-- VISTA PARA MOSTRAR RUTINAS PROGRAMADAS.
CREATE VIEW vista_programar_rutinas AS
SELECT v.marca AS 'Marca', v.modelo AS 'Modelo y Año', r.nombre AS 'Nombre de la Rutina', r.descripcion AS 'Descripcion de la Rutina', pr.fecha AS 'Fecha de Rutina programada'
FROM programar_rutinas pr
INNER JOIN vehiculos v ON pr.fk_id_vehiculos = v.id_vehiculos
INNER JOIN rutinas r ON pr.fk_id_rutinas = r.id_rutinas;

-- MOSTRAR
DROP PROCEDURE IF EXISTS mostrar_rutinas_programadas 
delimiter ;;
CREATE PROCEDURE mostrar_rutinas_programadas(IN _filtro VARCHAR(150))
BEGIN
	SELECT * FROM vista_programar_rutinas v WHERE marca LIKE _filtro ORDER BY v.Marca;
END;;


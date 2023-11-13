-- Creacion de la db
CREATE DATABASE car_care;

USE car_care;
-- TABLA VEHICULOS
CREATE TABLE vehiculos(
id_vehiculos INT PRIMARY KEY AUTO_INCREMENT, 
marca VARCHAR(150), 
modelo VARCHAR(150), 
tipo_vehiculo VARCHAR(150));

/*------------------------------------Procedure de la tabla Vehiculos CRUD------------------------------------------*/

/*PROCEDURE PARA INSERTAR E ACTUALIZAR*/
delimiter ;;
CREATE PROCEDURE insertar_vehiculos(
IN _marca VARCHAR(150),
IN _modelo VARCHAR(150),
IN _tipo_vehiculo VARCHAR(150),
IN _id_vehiculos INT)
BEGIN
IF _id_vehiculos < 0 then
INSERT INTO vehiculos VALUES (NULL,_marca,_modelo,_tipo_vehiculo);
ELSE IF _id_vehiculos > 0 then
UPDATE vehiculos SET marca = _marca, modelo = _modelo, tipo_vehiculo = _tipo_vehiculo WHERE id_vehiculos = _id_vehiculos;
END if;
END if;
END;;

/*PROCEDURE PARA MOSTRAR*/
delimiter ;;
CREATE PROCEDURE mostrar_vehiculos(
IN _filtro VARCHAR(150))
BEGIN
SELECT * FROM vehiculos WHERE marca LIKE _filtro ORDER BY id_vehiculos;
END;;


/*PROCEDURE PARA ELIMINAR*/
delimiter ;;
CREATE PROCEDURE eliminar_vehiculos(
IN _id_vehiculos INT)
BEGIN
DELETE FROM vehiculos AS v WHERE v.id_vehiculos = _id_vehiculos;
END;;

-- TABLA RUTINAS
CREATE TABLE rutinas(
id_rutinas INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(150),
descripcion VARCHAR(255));


-- CRUD DE RUTINAS.
-- INSERTAR y EDITAR
DROP PROCEDURE IF EXISTS insertar_rutinas
delimiter ;;
CREATE PROCEDURE insertar_rutinas(IN _nombre VARCHAR(150), IN _descripcion VARCHAR(255), _id_rutinas INT )
BEGIN
	IF _id_rutinas < 0 then
	INSERT INTO rutinas VALUES (NULL,_nombre,_descripcion);
	ELSE IF _id_rutinas > 0 then
	UPDATE rutinas SET nombre = _nombre, descripcion = _descripcion WHERE id_rutinas = _id_rutinas;
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
	SELECT r.id_rutinas,r.nombre AS 'Nombre de la rutina', r.descripcion AS 'Descripción de la rutina'  FROM rutinas r WHERE nombre LIKE filtro ORDER BY id_rutinas;
END;;


-- ------------------------------------------------------------------------------------------------------
-- TABLA PROGRAMACION DE RUTINAS
CREATE TABLE programar_rutinas(id_rut_programadas INT PRIMARY KEY AUTO_INCREMENT, fk_id_vehiculos INT,
fk_id_rutinas int, fecha VARCHAR(150),
FOREIGN KEY (fk_id_vehiculos) REFERENCES vehiculos (id_vehiculos),
FOREIGN KEY (fk_id_rutinas) REFERENCES rutinas (id_rutinas));



-- CRUD DE PROGRAMACION DE RUTINAS.
-- INSERTAR y EDITAR
delimiter ;;
CREATE PROCEDURE insertar_rutinas_programadas(IN _fk_id_vehiculos INT, IN _fk_id_rutinas INT, IN _fecha VARCHAR(255), IN _id_rut_programadas INT )
BEGIN
	if _id_rut_programadas < 0 then
	INSERT INTO programar_rutinas  VALUES (NULL,_fk_id_vehiculos,_fk_id_rutinas,_fecha);
	else if _id_rut_programadas > 0 then
	UPDATE programar_rutinas pr SET pr.fk_id_vehiculos = _fk_id_vehiculos, pr.fk_id_rutinas = _fk_id_rutinas, pr.fecha = _fecha WHERE pr.id_rut_programadas = _id_rut_programadas;
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
CREATE VIEW vista_programar_rutinas AS SELECT pr.id_rut_programadas, v.modelo, r.descripcion, pr.fecha FROM programar_rutinas pr
JOIN vehiculos v ON pr.fk_id_vehiculos = v.id_vehiculos JOIN rutinas r ON pr.fk_id_rutinas = r.id_rutinas;

-- MOSTRAR
delimiter ;;
CREATE PROCEDURE mostrar_rutinas_programadas(IN _filtro VARCHAR(150))
BEGIN
	SELECT * FROM vista_programar_rutinas v WHERE modelo LIKE _filtro ORDER BY v.modelo;
END;;


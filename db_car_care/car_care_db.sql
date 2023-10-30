-- Creacion de la db
CREATE DATABASE car_care;

USE car_care;
-- TABLA VEHICULOS
CREATE TABLE vehiculos(
id_vehiculos INT PRIMARY KEY AUTO_INCREMENT, 
marca VARCHAR(150), 
modelo VARCHAR(150), 
tipo_vehiculo VARCHAR(150));

-- TABLA RUTINAS
CREATE TABLE rutinas(
id_rutinas INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(150),
descripcion VARCHAR(255));

CREATE TABLE programar_rutinas(id_rut_programadas INT PRIMARY KEY AUTO_INCREMENT, 
fk_id_vehiculos INT, 
fk_id_rutinas INT, 
fecha VARCHAR(150),
FOREIGN KEY (fk_id_vehiculos) REFERENCES vehiculos (id_vehiculos),
FOREIGN KEY (fk_id_rutinas) REFERENCES rutinas (id_rutinas));

INSERT INTO vehiculos VALUES(NULL,'chevrolet','chevy 2006','carro');
INSERT INTO rutinas VALUES(NULL,'Motor','Cambio de aceite, Cambio de antiCongelante');
SELECT * FROM vehiculos, rutinas, programar_rutinas
INSERT INTO programar_rutinas VALUES(NULL,2,1,'02-11-2023');
/*------------------------------------Procedure de la tabla Vehiculos CRUD------------------------------------------*/

/*PROCEDURE PARA INSERTAR E ACTUALIZAR*/
delimiter ;;
CREATE PROCEDURE insertar_vehiculos(
IN _marca VARCHAR(150),
IN _modelo VARCHAR(150),
IN _tipo_vehiculo VARCHAR(150),
IN _id_vehiculos INT)
BEGIN
DECLARE x INT;
SELECT COUNT(*) FROM vehiculos WHERE marca = _marca INTO x;
IF x = 0 AND _id_vehiculos < 0 then
INSERT INTO vehiculos VALUES (NULL,_marca,_modelo,_tipo_vehiculo);
ELSE IF x = 0 AND _id_vehiculos > 0 then
UPDATE vehiculos SET marca = _marca, modelo = _modelo, tipo_vehiculo = _tipo_vehiculo WHERE id_vehiculos = _id_vehiculos;
ELSE
UPDATE vehiculos SET  modelo = _modelo, tipo_vehiculo = _tipo_vehiculo WHERE id_vehiculos = _id_vehiculos;
END if;
END if;
END;;

/*PROCEDURE PARA MOSTRAR*/
delimiter ;;
CREATE PROCEDURE mostrar_vehiculos(
IN _filtro VARCHAR(150))
BEGIN
SELECT v.marca, v.modelo , v.tipo_vehiculo FROM vehiculos AS v WHERE v.marca = _filtro;
END;;


/*PROCEDURE PARA ELIMINAR*/
delimiter ;;
CREATE PROCEDURE eliminar_vehiculos(
IN _id_vehiculos INT)
BEGIN
DELETE FROM vehiculos AS v WHERE v.id_vehiculos = _id_vehiculos;
END;;

/*------------------------------------Vista para Mostrar toda la consulta ------------------------------------------*/
CREATE VIEW vista_programar_rutinas AS
SELECT v.marca AS 'Marca', v.modelo AS 'Modelo y Año', r.nombre AS 'Nombre de la Rutina', r.descripcion AS 'Descripcion de la Rutina', pr.fecha AS 'Fecha de Rutina programa'
FROM programar_rutinas pr
INNER JOIN vehiculos v ON pr.fk_id_vehiculos = v.id_vehiculos
INNER JOIN rutinas r ON pr.fk_id_rutinas = r.id_rutinas;


SELECT * FROM vista_programar_rutinas;

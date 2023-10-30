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
CREATE TABLE rutinas(id_rutinas INT PRIMARY KEY AUTO_INCREMENT,nombre VARCHAR(150),descripcion VARCHAR(255));

CREATE TABLE programar_rutinas(id_rut_programadas INT PRIMARY KEY AUTO_INCREMENT, fk_id_vehiculos int, fk_id_rutinas int, fecha VARCHAR(150),
FOREIGN KEY (fk_id_vehiculos) REFERENCES vehiculos (id_vehiculos),
FOREIGN KEY (fk_id_rutinas) REFERENCES rutinas (id_rutinas));

/*soy un comentario*/
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


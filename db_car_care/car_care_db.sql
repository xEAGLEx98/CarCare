-- Creacion de la db
CREATE DATABASE car_care;

USE car_care;
-- TABLA VEHICULOS
CREATE TABLE vehiculos(id_vehiculos INT PRIMARY KEY AUTO_INCREMENT, marca VARCHAR(150), modelo VARCHAR(150), tipo_vehiculo VARCHAR(150));

-- TABLA RUTINAS
CREATE TABLE rutinas(id_rutinas INT PRIMARY KEY AUTO_INCREMENT,nombre VARCHAR(150),descripcion VARCHAR(255));

CREATE TABLE programar_rutinas(id_rut_programadas INT PRIMARY KEY AUTO_INCREMENT, fk_id_vehiculos int, fk_id_rutinas int, fecha VARCHAR(150),
FOREIGN KEY (fk_id_vehiculos) REFERENCES vehiculos (id_vehiculos),
FOREIGN KEY (fk_id_rutinas) REFERENCES rutinas (id_rutinas));

/*soy un comentario*/
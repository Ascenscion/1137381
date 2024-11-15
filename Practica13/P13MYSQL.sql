
create database p13;
use p13;
create table usuarios
(
    id       int auto_increment
        primary key,
    nombre     varchar(50)  not null,
    password varchar(100) not null
);
-- Crear tabla Productos
CREATE TABLE productos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(100),
    descripcion VARCHAR(100),
    marca VARCHAR(100),
    precio FLOAT,
    inventario INT
);

INSERT INTO productos (nombre, descripcion, marca, precio, inventario)
VALUES
('Refresco', '3 litros', 'Marca de cola', 7.5, 24),
('Chocolate', 'Barra de 100 gramos', 'Iberico', 12.5, 36);

DELIMITER //
create
    definer = root@localhost procedure p13.EditarProductos(IN p_nombre varchar(100), IN p_descripcion varchar(100),
                                                           IN p_marca varchar(100), IN p_precio float,
                                                           IN p_inventario int, IN p_id int)
BEGIN
    UPDATE productos
    SET nombre = p_nombre,
        descripcion = p_descripcion,
        marca = p_marca,
        precio = p_precio,
        inventario = p_inventario
    WHERE id = p_id;
END //
DELIMITER ;

DELIMITER //
create
    definer = root@localhost procedure p13.EliminarProducto(IN id_producto int)
BEGIN
    DELETE FROM productos WHERE id = id_producto;
END //
DELIMITER ;

DELIMITER //
create
    definer = root@localhost procedure p13.InsertarProductos(IN p_nombre varchar(100), IN p_descripcion varchar(100),
                                                             IN p_marca varchar(100), IN p_precio float,
                                                             IN p_inventario int)
BEGIN
    INSERT INTO productos (nombre, descripcion, marca, precio, inventario)
    VALUES (p_nombre, p_descripcion, p_marca, p_precio, p_inventario);
END //
DELIMITER ;

DELIMITER //
create
    definer = root@localhost procedure p13.MostrarProductos()
BEGIN
    SELECT * FROM productos;
END //
DELIMITER ;


CALL MostrarProductos();

call EditarProductos("A","B","C",20,2,1);
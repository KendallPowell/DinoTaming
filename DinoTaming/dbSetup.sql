CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS dinos(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        type VARCHAR(30) NOT NULL,
        picture VARCHAR(255) NOT NULL DEFAULT 'https://media.istockphoto.com/id/104018711/photo/tyrannosaur.jpg?s=612x612&w=is&k=20&c=-dN226JpIc2rZPxrXaJH0aP4aZPhTTCTTIEQegRqc8E=' name VARCHAR(25) NOT NULL,
        level INT NOT NULL,
        creatorId VARCHAR(255) NOT NULL FOREIGN KEY (creatorId) REFERENCES accounts (id) ON DELETE CASCADE
    ) default charset utf8 COMMENT '';
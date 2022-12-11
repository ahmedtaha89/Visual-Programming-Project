use Project_database


-- create tables

CREATE TABLE categories (
	category_id INT IDENTITY (1, 1) PRIMARY KEY,
	category_name VARCHAR (255) NOT NULL
);

INSERT INTO categories (category_name)
values('Mobiles'),('Tablets');


select * from categories;



CREATE TABLE brands (
	brand_id INT IDENTITY (1, 1) PRIMARY KEY,
	brand_name VARCHAR (255) NOT NULL
);

INSERT INTO brands (brand_name)
values ('LG'),('Lenovo'),('Nokia') ,('HP'),('Huawei'),('HTC'),('Sony'),('Samsung'),('Tecno'),('Oppo'),('infinix')

INSERT INTO brands (brand_name)
values ('Xiaomi'),('realme'),('Darago 5products'); 

SELECT * FROM brands;



CREATE TABLE products (
	product_id INT IDENTITY (1, 1) PRIMARY KEY,
	product_name VARCHAR (255) NOT NULL,
	brand_id INT NOT NULL,
	category_id INT NOT NULL,
	list_price decimal  NOT NULL,
	details varchar(max) not null,
	discount decimal  null,

	FOREIGN KEY (category_id) 
	REFERENCES categories (category_id),

	FOREIGN KEY (brand_id) 
	REFERENCES brands (brand_id) 
	);

	drop table products



	select * from products;

	insert into products(product_name,brand_id,category_id,list_price,details,discount)
	values('Apple',1,1,18000,'iPhone 8 Plus, 256 GB, 4G LTE - Red',200)





--	INSERT INTO SaveFiles ( Name ,image )
--SELECT 'Home Page 2', 
--	BulkColumn FROM OPENROWSET(BULK N'F:\Python\Images\.jpg', SINGLE_BLOB) image;

CREATE TABLE customers (
	customer_id INT IDENTITY (1, 1) PRIMARY KEY,
	first_name VARCHAR (255) NOT NULL,
	last_name VARCHAR (255) NOT NULL,
	phone VARCHAR (25) not null unique,
	email VARCHAR (255) NOT NULL unique,
	country varchar(100) 
);



insert into customers(first_name,last_name,phone,email)
values ('ammar','yasser','0118985985','ammar90@gmail.com')

select * from customers;


CREATE TABLE orders (
	order_id INT IDENTITY (1, 1) PRIMARY KEY,
	customer_id INT,
	order_date DATE NOT NULL,
	required_date DATE NOT NULL,
	shipped_date DATE,
	FOREIGN KEY (customer_id) REFERENCES customers (customer_id)
);

insert into orders (customer_id,order_date,required_date,shipped_date)
values(1,'2022-5-11','2022-5-12','2022-5-13')

select * from orders

CREATE TABLE order_items (
	
	item_id INT  IDENTITY (1, 1) PRIMARY KEY,
	order_id INT,
	product_id INT NOT NULL,
	quantity INT NOT NULL,
	list_price numeric(10,2) NOT NULL,
	discount numeric(10,2) ,
	
	FOREIGN KEY (order_id)
	REFERENCES orders (order_id),

	FOREIGN KEY (product_id) 
	REFERENCES products (product_id));


select * from order_items

insert into order_items (order_id,product_id,quantity,list_price,discount)
values(1,2,2,18000.00,100.00)


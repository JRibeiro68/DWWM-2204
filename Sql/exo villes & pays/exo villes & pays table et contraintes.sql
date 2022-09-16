
DROP TABLE IF EXISTS cities;
DROP TABLE IF EXISTS countries;

CREATE TABLE countries
(
	country_code CHAR(2) PRIMARY KEY,
	country_name VARCHAR(200) NOT NULL
);

CREATE TABLE cities
(
	city_id INT PRIMARY KEY,
	city_name VARCHAR(100) NOT NULL,
	country_code CHAR(2) NOT NULL,
	number_of_cities VARCHAR(255) NOT NULL,
	FOREIGN KEY (country_code) REFERENCES countries(country_code)
);

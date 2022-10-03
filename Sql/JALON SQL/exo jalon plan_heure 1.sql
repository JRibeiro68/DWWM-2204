DROP TABLE IF EXISTS planes;
DROP TABLE IF EXISTS manufacturers;


CREATE TABLE manufacturers
(
	plane_maker_id SERIAL,
	plane_maker VARCHAR(50),
	PRIMARY KEY(plane_maker_id)
);

CREATE TABLE planes
(
	plane_ref CHAR(5),
	plane_capacity INT,
	plane_autonomy INT,
	plane_speed INT,
	plane_date DATE,
	plane_maker_id SERIAL,
	PRIMARY KEY(plane_ref),
	FOREIGN KEY(plane_maker_id) REFERENCES manufacturers(plane_maker_id)
);

ALTER TABLE planes
	ADD CONSTRAINT plane_number;
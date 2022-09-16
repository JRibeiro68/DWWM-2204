INSERT INTO countries
(country_code, country_name)
values

('FR', 'France'),
('US', 'United States'),
('RU', 'Russian Federation');


INSERT INTO cities
(city_name, country_code)
VALUES
(1, 'Paris', 'FR'),
(2,'Lyon', 'FR'),
(3, 'Toulouse', 'FR'),
(4, 'Marseille', 'FR'),
(5, 'Mulhouse', 'FR'),
(6, 'Boston', 'US'),
(7, 'Los angeles', 'US'),
(8, 'Washington', 'US'),
(9, 'New York', 'US'),
(10, 'Moscou', 'RU'),
(11, 'Saint Petersbourg', 'RU');



SELECT * FROM cities;

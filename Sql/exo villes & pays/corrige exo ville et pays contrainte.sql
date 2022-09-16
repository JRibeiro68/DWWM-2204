INSERT INTO countries
(country_code, country_name)
values

('FR', 'France'),
('US', 'United States'),
('RU', 'Russian Federation');


INSERT INTO cities
(city_name, country_code)
VALUES

('Paris', 'FR')
('Lyon', 'FR')
('Toulouse', 'FR')
('Marseille', 'FR')
('Mulhouse', 'FR')
('Boston', 'US')
('Los angeles', 'US')
('Washington', 'US')
('New York', 'US')
('Moscou', 'RU')
('Saint Petersbourg', 'RU');

SELECT * FROM cities;

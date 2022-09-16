SELECT * FROM countries;
SELECT * FROM cities;

-- 1. Sélectionner le nom de toutes les villes

SELECT city_name FRFOM cities;
SELECT CITY_name
FROM cities
WHERE city_name LIKE 'M%' OR city_name LIKE 'm%';

SELECT city_name
FROM cities
WHERE city_name LIKE '%e';

SELECT city_name
FROM cities
WHERE city_name NOT LIKE '%1%';

SELECT city_name , LENGTH(city_name) AS longueur
FROM cities
GROUP BY city_id
HAVING LENGTH(city_name) >5
ORDER BY longueur ASC
LIMIT 3;

SELECT city_name , LENGTH(city_name) AS longueur
FROM cities
GROUP BY city_id
HAVING LENGTH(city_name) >5
ORDER BY longueur ASC
LIMIT 3 OFFSET 2;

-- 2. Sélectionner l'identifiant et le nom de toutes les villes triées par nom de ville et par ordre alphabétique

SELECT city_id,city_name FROM cities ORDER BY city_name ASC;

-- 3. Sélectionner toutes les villes avec le nom du pays associé à chaque ville. Trier la liste par code pays et par ordre alphabétique.

SELECT city_name , country_name
FROM countries
NATURAL JOIN cities
ORDER BY country_code DESC;

-- Equivalent de la requête du dessus
SELECT city_name , country_name
FROM cities
INNER JOIN countries ON cities.country_code = countries.country_code
ORDER BY cities.country_code DESC;

-- 4. Sélectionner le code ISO et le nom de tous les pays avec le nombre de ville par pays.
-- Les pays avec le moins de villes apparaissent en 1er.

SELECT countries.country_code, countries.country_name,
COUNT(cities,*) AS nb_ville
FROM countries
NATURAL JOIN cities
GROUP BY cities.country_code, countries.country_name
ORDER BY nb_ville;

SELECT cities.city_id, cities.city_name,
cities.country_code,
countries.country_code,
countries.country_name
FROM countries NATURAL JOIN cities;

-- 5. Créer la requête SELECT correspondant au résultat suivant :

SELECT city_id, city_name, country_code,
country_name, COUNT (cities.*) AS number_of_cities
--1)Sélectionner le nom de toutes les villes.
SELECT city_name FROM cities;

--2)Sélectionner l'identifiant et le nom de toutes les villes triées par nom de ville et par ordre alphabétique.
SELECT city_id, city_name FROM cities ORDER BY city_name ASC;

--3)Sélectionner toutes les villes avec le nom du pays associé à chaque ville. Trier lz liste pas code pays et par ordre alphabétique inverse.
SELECT city_name, country_name from cities inner join countries on cities.country_code = countries.country_code;

--4)Sélectionner le code ISO et le nom de tous les pays avec le nombre de villles par pays. Les pays avec le moins de villes apparaissent en 1er.
SELECT country_code, country_name, city_name from countries, cities order by country_code ASC;


--5)Créer la requête SELECT correspondant au résultat donné dnas l'exercice.
SELECT COUNT(number_of_cities) FROM cities;
SELECT * from cities;



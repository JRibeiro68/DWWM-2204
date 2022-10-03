-- Sélectionner la référence, l'auonomie et la vitesse de tous le savions.
-- Triés du plus rapide au plus lent.

SELECT plane_ref, plane_autonomy, plane_speed
FROM planes
ORDER BY plane_speed DESC;

-- Sélectionner la référence, la capacité, l'autonomie et le nom du fabricant de tous les avions.
-- Les avions sont triés par fabricant(croissant) et par autonomie(décroissant).

SELECT plane_ref, plane_capacity, plane_autonomy, plane_maker
FROM planes
NATURAL JOIN manufacturers
ORDER BY plane_maker ASC, plane_autonomy DESC;

-- Sélectionner toutes les informations des avions dont le nom de fabricant commence par la lettre "B".

SELECT plane_maker, plane_ref, plane_capacity, plane_autonomy, plane_speed, plane_date
FROM planes
NATURAL JOIN manufacturers
WHERE plane_maker LIKE 'B%';

-- Sélectionner toutes les informations des avions dont la vitesse est supérieur à 1000km/h et dont la capacité dépasse 10 passagers.

SELECT plane_speed, plane_capacity, plane_autonomy, plane_ref, plane_maker, plane_date
FROM planes
NATURAL JOIN manufacturers
WHERE plane_speed > 1000 AND plane_capacity > 10;

-- Sélectionner le nom de tous les fabricants avec, pour chacun d'entre eux, le nombre d'avions et la vitesse moyenne de la flotte.
-- Les fabricant possédant le moins d'avions apparaissent en premier.

SELECT plane_maker, plane_number
FROM planes;
COUNT (DISTINCT plane_maker)
FROM manufacturers;
AVG plane_speed
FROM planes
ORDER BY plane_maker ASC;

-- Sélectionner le nom de tous les fabricants avec, pour chacun d'entre eux, le nom et la capacité de l'avion pouvant acceuillir le plus de passagers ainsi que le nom et l'autonomie de l'avion pouvant parcourir le plus de kilomètres

SELECT plane_maker, plane_ref, plane_capacity, plane_autonomy
FROM planes;
SELECT COUNT(plane_capacity) FROM planes WHERE plane_maker = 'AIRBUS', 'BOEING', 'Bombardier', 'Dassault', 'Cessna';
NATURAL JOIN manufacturers;



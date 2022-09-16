SELECT * FROM owners
SELECT * FROM brands
SELECT * FROM cars
SELECT * FROM cars_owners


-- Sélectionner le nom et le numéro d'immatriculation de toutes les voitures triées par immatriculation (ordre croissant).

SELECT car_name, car_registration
FROM cars
NATURAL JOIN cars_owners
ORDER BY car_registration ASC;


-- Selectionner toutes les informations de toutes les voitures, incluant le nom de la marque ainsi que le nom et prénom du propriétaire.
-- Trier la liste par nom de marque(ordre croissant) puis par nom de propriétaire(ordre croissant).

SELECT cars.*, brand_name, owner_lastname, owner_firstname, car_registration
FROM cars
NATURAL JOIN brands
INNER JOIN cars_owners ON cars_owners.car_id = cars.car_id
INNER JOIN owners ON  owners.owner_id = cars_owners.car_owner_id
ORDER BY brand_name, owner_lastname ASC;


-- Sélectionner le nom de toutes les marques incluant le nombre de voitures de chaque marque.

SELECT brand_name,
COUNT (car_id)
FROM brands
NATURAL JOIN cars
GROUP BY brand_name;


--Sélectionner le nom de toutes les marques avec le nombre de propriétaires de chaque marque.

SELECT brand_name,
COUNT (car_owner_id)
FROM brands
NATURAL JOIN cars
NATURAL JOIN cars_owners
GROUP BY brand_name


-- Sélectionner les  prénoms des propriétaires dont le prénom commencent pas la lettre A.

SELECT owner_firstname
FROM owners
WHERE owner_firstname LIKE 'A%';

-- Sélectionner le nom et prénom des propriétaires dont le prénom contient plus de 5 lettres.

SELECT owner_lastname, owner_firstname
FROM owners
WHERE LENGTH(owner_firstname) > 5;

-- Sélectionner les noms et prénoms des propriétaires possédant plus d'une voiture avec le nombre de voitures possédées par propriétaire.
-- Trier la liste par nombre de voitures possédées.
-- Les propriétaires possédant le plus de voitures apparaissent en 1er.

SELECT owner_lastname, owner_firstname,
COUNT (car_id)
FROM owners
ORDER BY 

-- Sélectionner les noms et prénoms des propriétaires possédant plus d'une voiture de même marque.
-- Pour chaque marque de voiture trouvée, afficher le nom de la marque et le nombre de voitures possédées pour cette marque.


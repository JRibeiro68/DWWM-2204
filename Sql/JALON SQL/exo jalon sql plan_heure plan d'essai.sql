INSERT INTO manufacturers
(plane_maker)
VALUES
('AIRBUS'),
('AIRBUS'),
('AIRBUS'),
('AIRBUS'),
('BOEING'),
('BOEING'),
('BOEING'),
('BOEING'),
('Bombardier'),
('Bombardier'),
('Dassault'),
('Dassault'),
('Cessna'),
('Cessna');


INSERT INTO planes
(plane_ref, plane_capacity, plane_autonomy, plane_speed, plane_date, plane_maker_id)
VALUES
('A300', 290, 7500, 900, '23/05/1974', 1),
('A320', 180, 5000, 900, '18/04/1988', 2),
('A350', 440, 11800, 920, '15/01/2015', 3),
('A380', 300, 15200, 903, '15/10/2007', 4),
('717', 125, 9000, 890, '12/10/1999', 5),
('737', 200, 14800, 920, '12/02/1968', 6),
('747', 3500, 10500, 900, '22/01/1970', 7),
('777', 270, 16500, 980, '07/06/1995', 8),
('C3500', 10, 6297, 1025, '12/01/2004', 9),
('G7500', 19, 13705, 1150, '20/10/2014', 10),
('F2000', 12, 5500, 851, '04/03/1993', 11),
('F8X', 14, 11945, 1100, '06/02/2015', 12),
('CJ1', 5, 2200, 650, '29/04/1991', 13),
('XLS', 10, 3600, 805, '29/07/1998', 14);


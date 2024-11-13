SET IDENTITY_INSERT Items ON;
INSERT INTO Items (Id, Name, Type, Attack, Defense)
VALUES
    (1, 'Sword','Weapon', 10, 1),
    (2, 'Platemail','Armor', 0, 6),
    (3, 'Club','Weapon', 6, 0),
    (4, 'Spiked Shield','Armor', 5, 2),
    (5, 'Moltov','Weapon', 2, 0),
    (6, 'Rusty Helmet','Armor', 0, 3);



SET IDENTITY_INSERT Equipments ON;
INSERT INTO Equipments (Id, WeaponId, ArmorId)
VALUES
    (1, 1, 2),
    (2, 3, 5),
    (3, 6, 1);


SET IDENTITY_INSERT Items OFF;
SET IDENTITY_INSERT Equipments OFF;


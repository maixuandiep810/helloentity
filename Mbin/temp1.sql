INSERT INTO `helloentity`.`Users`
(
`Active`,
`UpdatedTime`,
`CreatedTime`,
`Username`,
`Password`,
`Email`,
`AvatarUrl`)
VALUES
(
0,
'2020-03-31',
'2020-03-31',
'user1',
'',
'',
'');



/*--------*/
INSERT INTO `helloentity`.`Roles`
(
`Active`,
`UpdatedTime`,
`CreatedTime`,
`Name`,
`DisplayName`)
VALUES
(0,
'2020-03-31',
'2020-03-31',
'admin',
'QTV');
INSERT INTO `helloentity`.`Roles`
(
`Active`,
`UpdatedTime`,
`CreatedTime`,
`Name`,
`DisplayName`)
VALUES
(0,
'2020-03-31',
'2020-03-31',
'guest',
'Khach');


/*--------*/
INSERT INTO `helloentity`.`UserRoles`
(
`Active`,
`UpdatedTime`,
`CreatedTime`,
`UserId`,
`RoleId`)
VALUES
(0,
'2020-03-31',
'2020-03-31',
'1',
'1');

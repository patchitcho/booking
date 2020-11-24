IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE TABLE [Adresse] (
        [AdresseId] int NOT NULL IDENTITY,
        [Societé] nvarchar(max) NULL,
        [Nom] nvarchar(max) NULL,
        [Prenom] nvarchar(max) NULL,
        [Telephone] int NOT NULL,
        [Email] nvarchar(max) NULL,
        [Adress] nvarchar(max) NULL,
        [Ville] nvarchar(max) NULL,
        [Codepostale] int NOT NULL,
        [Latitude] nvarchar(max) NULL,
        [Longitude] nvarchar(max) NULL,
        [Agenceid] int NOT NULL,
        [Commentaire] nvarchar(max) NULL,
        [Type] nvarchar(max) NULL,
        CONSTRAINT [PK_Adresse] PRIMARY KEY ([AdresseId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE TABLE [Agence] (
        [AgenceId] int NOT NULL IDENTITY,
        [Libellé] nvarchar(max) NULL,
        CONSTRAINT [PK_Agence] PRIMARY KEY ([AgenceId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE TABLE [Course] (
        [CourseId] int NOT NULL IDENTITY,
        [Adressenlevement] nvarchar(max) NULL,
        [Adresslivraison] nvarchar(max) NULL,
        CONSTRAINT [PK_Course] PRIMARY KEY ([CourseId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE TABLE [Sondage] (
        [SondageId] int NOT NULL IDENTITY,
        [Libellé] nvarchar(max) NULL,
        [Question] nvarchar(max) NULL,
        [Type] nvarchar(max) NULL,
        [Statut] nvarchar(max) NULL,
        [Obligatoire] bit NOT NULL,
        CONSTRAINT [PK_Sondage] PRIMARY KEY ([SondageId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE TABLE [Tournee] (
        [TourneeId] int NOT NULL IDENTITY,
        [Libellé] nvarchar(max) NULL,
        [Date_tournee] datetime2 NOT NULL,
        [LivreurId] int NOT NULL,
        [VehiculeId] int NOT NULL,
        [Type] nvarchar(max) NULL,
        [Agenceid] int NOT NULL,
        CONSTRAINT [PK_Tournee] PRIMARY KEY ([TourneeId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE TABLE [Vehicules] (
        [VehiculesId] int NOT NULL IDENTITY,
        [Nom] nvarchar(max) NULL,
        [Poid] int NOT NULL,
        [Matriculation] nvarchar(max) NULL,
        CONSTRAINT [PK_Vehicules] PRIMARY KEY ([VehiculesId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE TABLE [Zone] (
        [zoneId] int NOT NULL IDENTITY,
        [zone] nvarchar(max) NULL,
        [ville] nvarchar(max) NULL,
        [codepostal] int NOT NULL,
        CONSTRAINT [PK_Zone] PRIMARY KEY ([zoneId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(128) NOT NULL,
        [ProviderKey] nvarchar(128) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(128) NOT NULL,
        [Name] nvarchar(128) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191205150131_init')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191205150131_init', N'3.1.0');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191207172948_init2')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Zone]') AND [c].[name] = N'zone');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Zone] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Zone] ALTER COLUMN [zone] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191207172948_init2')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Zone]') AND [c].[name] = N'ville');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Zone] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Zone] ALTER COLUMN [ville] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191207172948_init2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191207172948_init2', N'3.1.0');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    DROP TABLE [Vehicules];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Tournee]') AND [c].[name] = N'Libellé');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Tournee] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Tournee] ALTER COLUMN [Libellé] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sondage]') AND [c].[name] = N'Type');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Sondage] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Sondage] ALTER COLUMN [Type] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sondage]') AND [c].[name] = N'Statut');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Sondage] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Sondage] ALTER COLUMN [Statut] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sondage]') AND [c].[name] = N'Question');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Sondage] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Sondage] ALTER COLUMN [Question] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sondage]') AND [c].[name] = N'Libellé');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Sondage] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Sondage] ALTER COLUMN [Libellé] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Course]') AND [c].[name] = N'Adresslivraison');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Course] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Course] ALTER COLUMN [Adresslivraison] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Course]') AND [c].[name] = N'Adressenlevement');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Course] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [Course] ALTER COLUMN [Adressenlevement] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [name] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [profilId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [Discriminator] nvarchar(max) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    ALTER TABLE [AspNetUserRoles] ADD [ProfilId] nvarchar(450) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Adresse]') AND [c].[name] = N'Ville');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Adresse] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [Adresse] ALTER COLUMN [Ville] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    DECLARE @var10 sysname;
    SELECT @var10 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Adresse]') AND [c].[name] = N'Societé');
    IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Adresse] DROP CONSTRAINT [' + @var10 + '];');
    ALTER TABLE [Adresse] ALTER COLUMN [Societé] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    DECLARE @var11 sysname;
    SELECT @var11 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Adresse]') AND [c].[name] = N'Nom');
    IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Adresse] DROP CONSTRAINT [' + @var11 + '];');
    ALTER TABLE [Adresse] ALTER COLUMN [Nom] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    DECLARE @var12 sysname;
    SELECT @var12 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Adresse]') AND [c].[name] = N'Adress');
    IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Adresse] DROP CONSTRAINT [' + @var12 + '];');
    ALTER TABLE [Adresse] ALTER COLUMN [Adress] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    CREATE TABLE [Vehicule] (
        [VehiculeId] int NOT NULL IDENTITY,
        [Nom] nvarchar(max) NOT NULL,
        [Poid] int NOT NULL,
        [Matriculation] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Vehicule] PRIMARY KEY ([VehiculeId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_ProfilId] ON [AspNetUserRoles] ([ProfilId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    ALTER TABLE [AspNetUserRoles] ADD CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_ProfilId] FOREIGN KEY ([ProfilId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223143727_profil')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191223143727_profil', N'3.1.0');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223145225_profil1')
BEGIN
    ALTER TABLE [AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_ProfilId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223145225_profil1')
BEGIN
    DROP INDEX [IX_AspNetUserRoles_ProfilId] ON [AspNetUserRoles];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223145225_profil1')
BEGIN
    DECLARE @var13 sysname;
    SELECT @var13 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUserRoles]') AND [c].[name] = N'ProfilId');
    IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUserRoles] DROP CONSTRAINT [' + @var13 + '];');
    ALTER TABLE [AspNetUserRoles] DROP COLUMN [ProfilId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223145225_profil1')
BEGIN
    ALTER TABLE [AspNetRoles] ADD [ProfilId] nvarchar(450) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223145225_profil1')
BEGIN
    CREATE INDEX [IX_AspNetRoles_ProfilId] ON [AspNetRoles] ([ProfilId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223145225_profil1')
BEGIN
    ALTER TABLE [AspNetRoles] ADD CONSTRAINT [FK_AspNetRoles_AspNetUsers_ProfilId] FOREIGN KEY ([ProfilId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223145225_profil1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191223145225_profil1', N'3.1.0');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223172245_accees')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName', N'ProfilId') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
        SET IDENTITY_INSERT [AspNetRoles] ON;
    INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName], [ProfilId])
    VALUES (N'671c3f34-36c8-4eac-a198-502cdfe8b4c3', N'43c9d552-da99-4dc8-9566-ad18efe00e05', N'Admin', N'ADMIN', NULL),
    (N'6bc232d0-47a8-466a-aec1-a78ad76b6a87', N'9d8c9e54-be5e-4e6e-be78-a2b40a747a12', N'TourneeRead', N'TourneeRead', NULL),
    (N'd43ab8b6-51ea-407c-a91b-c11a9a0aeb05', N'74e216fa-a275-4d99-b7d1-f23f69d491db', N'TourneeCreat', N'TourneeCreat', NULL),
    (N'2e484cb3-7118-48ee-86aa-56072cff74a3', N'757a07b6-d806-44b7-aebd-d756ca7814f3', N'CourseDlet', N'CourseDlet', NULL),
    (N'2a05b3ff-16e9-493e-b4a6-5dad27044534', N'63aa1c09-2951-44f4-83e2-0cafea3dd366', N'CourseUpdt', N'CourseUpdt', NULL),
    (N'655ffac2-5e91-4ed2-b5da-c6ed08b6a36d', N'e5769292-447c-46d5-97e6-a68f5db5054e', N'CourseRead', N'CourseRead', NULL),
    (N'6448ca0e-71ac-488d-b06e-8523230479c6', N'81499670-066e-46de-8d03-b48639bf029a', N'CourseCreat', N'CourseCreat', NULL),
    (N'816aaba6-9562-4781-b8c4-aed89f256b94', N'dd2736d4-3225-4e30-9b15-460728956a46', N'AdresseDlet', N'AdresseDlet', NULL),
    (N'74eefd9f-02a1-4efe-977f-47a7ba44c32f', N'd68fe02f-106d-445b-8b8f-fb19c695c922', N'AdresseUpdt', N'AdresseUpdt', NULL),
    (N'0499cd0a-1d3d-486a-b31a-a53313947b3c', N'093036e8-9e5d-4db1-b860-2e001893c744', N'AdresseRead', N'AdresseRead', NULL),
    (N'083fb77b-c657-4d91-9b1e-f69ed0fd01d2', N'adf843a5-1ff5-4fca-b281-c6a9b543f056', N'AdresseCreat', N'AdresseCreat', NULL),
    (N'258b8747-801a-482d-959c-3f3c89b0096d', N'992c9796-2229-4e42-8c8a-9cada7c91810', N'AgenceDlet', N'AgenceDlet', NULL),
    (N'2079eaac-dd90-45b3-96fe-cf89454f62c1', N'14b3772d-2409-465b-9954-949538be500b', N'AgenceUpdt', N'AgenceUpdt', NULL),
    (N'ad697b99-8515-47c4-abd9-41bd6ed9f8c8', N'a933bd60-c3f2-4477-a13b-0f0d48f12329', N'TourneeUpdt', N'TourneeUpdt', NULL),
    (N'75b185ba-4e98-477f-b9ec-c18ac990e6b5', N'e00e2a26-1f8e-44e3-809a-ad2a08e0dae6', N'AgenceRead', N'AgenceRead', NULL),
    (N'323d80ec-131d-4e16-8900-faa6f0368a05', N'7bb825c5-792c-4d2b-8804-5c6567e1f4d3', N'ZoneDlet', N'ZoneDlet', NULL),
    (N'0271e846-eb67-409e-af24-1fee48982897', N'14074b29-ffd7-4fb7-b666-106b6b52466e', N'ZoneUpdt', N'ZoneUpdt', NULL),
    (N'fb87144b-49d9-4d54-a234-48a770f846df', N'91a0a81c-4d6e-4403-bb97-c884fd78954b', N'ZoneRead', N'ZoneRead', NULL),
    (N'b1906b8f-7416-46af-bffd-89effd4b3057', N'7585ac36-1101-4922-8391-a42aa3e4291f', N'ZoneCreat', N'ZoneCreat', NULL),
    (N'0c59916b-8238-45b8-ad16-1db52eea075a', N'db314e89-e819-48d8-bc19-8ea4b5c7384c', N'SondageDlet', N'SondageDlet', NULL),
    (N'b9d1c564-cecf-4bff-8528-adcbb1cc1527', N'5804382c-7f2f-488c-b04e-81d9d003629c', N'SondageUpdt', N'SondageUpdt', NULL),
    (N'f69f6d5a-363f-40fa-a964-19ba7dce66e8', N'60aa7b13-ef86-4531-95a9-f52d32966637', N'SondageRead', N'SondageRead', NULL),
    (N'1426379a-41c8-47d2-acc2-4eae9f64953c', N'69c23d87-4cc5-474a-a61d-50c889e63298', N'SondageCreat', N'SondageCreat', NULL),
    (N'177da35d-cfaf-46ba-89d1-332dc579c4bf', N'bd8c8988-942a-46b3-9ffa-fd6d044ef532', N'VehiculeDlet', N'VehiculeDlet', NULL),
    (N'3b6febf6-5bf0-4eb7-9cfe-eac6900deea0', N'1c1d3287-b0b3-4976-ab10-ad8bd991c09d', N'VehiculeUpdt', N'VehiculeUpdt', NULL),
    (N'59abb89d-87c1-494f-aee5-435c50956f98', N'ad91181b-c6b6-4eee-8b1e-e5e446f24ede', N'VehiculeRead', N'VehiculeRead', NULL),
    (N'fecd1e0f-21b3-4958-b76e-06451aea7740', N'173573f6-a527-4c0c-98d2-2021da3a0752', N'VehiculeCreat', N'VehiculeCreat', NULL),
    (N'94ce159b-f90a-49bf-97b6-26d52d76de5f', N'f05cf539-de3f-4843-8588-d9da37e893c3', N'AgenceCreat', N'AgenceCreat', NULL),
    (N'5e63715b-7bce-468d-91a6-480f94124833', N'28b3e004-98e4-46f6-894c-962b35a19337', N'TourneeDlet', N'TourneeDlet', NULL);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName', N'ProfilId') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
        SET IDENTITY_INSERT [AspNetRoles] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223172245_accees')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191223172245_accees', N'3.1.0');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    ALTER TABLE [AspNetRoles] DROP CONSTRAINT [FK_AspNetRoles_AspNetUsers_ProfilId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DROP INDEX [IX_AspNetRoles_ProfilId] ON [AspNetRoles];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'0271e846-eb67-409e-af24-1fee48982897';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'0499cd0a-1d3d-486a-b31a-a53313947b3c';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'083fb77b-c657-4d91-9b1e-f69ed0fd01d2';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'0c59916b-8238-45b8-ad16-1db52eea075a';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'1426379a-41c8-47d2-acc2-4eae9f64953c';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'177da35d-cfaf-46ba-89d1-332dc579c4bf';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'2079eaac-dd90-45b3-96fe-cf89454f62c1';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'258b8747-801a-482d-959c-3f3c89b0096d';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'2a05b3ff-16e9-493e-b4a6-5dad27044534';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'2e484cb3-7118-48ee-86aa-56072cff74a3';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'323d80ec-131d-4e16-8900-faa6f0368a05';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'3b6febf6-5bf0-4eb7-9cfe-eac6900deea0';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'59abb89d-87c1-494f-aee5-435c50956f98';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'5e63715b-7bce-468d-91a6-480f94124833';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'6448ca0e-71ac-488d-b06e-8523230479c6';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'655ffac2-5e91-4ed2-b5da-c6ed08b6a36d';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'671c3f34-36c8-4eac-a198-502cdfe8b4c3';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'6bc232d0-47a8-466a-aec1-a78ad76b6a87';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'74eefd9f-02a1-4efe-977f-47a7ba44c32f';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'75b185ba-4e98-477f-b9ec-c18ac990e6b5';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'816aaba6-9562-4781-b8c4-aed89f256b94';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'94ce159b-f90a-49bf-97b6-26d52d76de5f';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'ad697b99-8515-47c4-abd9-41bd6ed9f8c8';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'b1906b8f-7416-46af-bffd-89effd4b3057';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'b9d1c564-cecf-4bff-8528-adcbb1cc1527';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'd43ab8b6-51ea-407c-a91b-c11a9a0aeb05';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'f69f6d5a-363f-40fa-a964-19ba7dce66e8';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'fb87144b-49d9-4d54-a234-48a770f846df';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'fecd1e0f-21b3-4958-b76e-06451aea7740';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DECLARE @var14 sysname;
    SELECT @var14 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'name');
    IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var14 + '];');
    ALTER TABLE [AspNetUsers] DROP COLUMN [name];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DECLARE @var15 sysname;
    SELECT @var15 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'profilId');
    IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var15 + '];');
    ALTER TABLE [AspNetUsers] DROP COLUMN [profilId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DECLARE @var16 sysname;
    SELECT @var16 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'Discriminator');
    IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var16 + '];');
    ALTER TABLE [AspNetUsers] DROP COLUMN [Discriminator];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    DECLARE @var17 sysname;
    SELECT @var17 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetRoles]') AND [c].[name] = N'ProfilId');
    IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [AspNetRoles] DROP CONSTRAINT [' + @var17 + '];');
    ALTER TABLE [AspNetRoles] DROP COLUMN [ProfilId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    CREATE TABLE [IdentityRole] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(max) NULL,
        [NormalizedName] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_IdentityRole] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    CREATE TABLE [IdentityUser] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(max) NULL,
        [NormalizedUserName] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [NormalizedEmail] nvarchar(max) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_IdentityUser] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[IdentityRole]'))
        SET IDENTITY_INSERT [IdentityRole] ON;
    INSERT INTO [IdentityRole] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
    VALUES (N'6ecb5ea3-bc2c-4104-9039-e6cdfa90cb8b', N'5ca21059-f849-4b21-8520-441a7690117f', N'Admin', N'ADMIN'),
    (N'ef014bd2-48d9-4d1c-b979-5408c7b1f1b9', N'2d7092e7-0a52-4f2f-93fa-fb17e2785048', N'TourneeUpdt', N'TourneeUpdt'),
    (N'0ad4642f-b9cb-4984-8711-ccd12eae39ea', N'3c26426b-2d0d-4580-9a64-d2a47d199926', N'TourneeRead', N'TourneeRead'),
    (N'b36590f6-15de-424c-90bb-445843f461aa', N'6d82d3bb-fd3e-4b0e-b2f8-53cf5207706b', N'TourneeCreat', N'TourneeCreat'),
    (N'4708784e-83e1-4436-9657-c54bd82456f7', N'418c1a02-ad97-4d73-9720-edeaf11928e9', N'CourseDlet', N'CourseDlet'),
    (N'b3cb1cd9-4e07-4031-8d6d-99871ed3fcdd', N'1784cdca-8288-45df-9942-c27b60487b5e', N'CourseUpdt', N'CourseUpdt'),
    (N'ed636012-715c-4cfa-8f8e-39aa66c41628', N'df4057fe-a956-4019-8199-b3cbf31c0e14', N'CourseRead', N'CourseRead'),
    (N'5a242a31-76c8-4ed4-91b3-55f9fc4a3800', N'86efcd0d-7d41-4a88-8c5d-30ead472dee5', N'CourseCreat', N'CourseCreat'),
    (N'67384571-5cb6-46bc-87a0-6e38b9379893', N'21bcd5e9-02d0-4136-ad33-773dd71b130e', N'AdresseDlet', N'AdresseDlet'),
    (N'a80aabae-8bc0-47f4-b06b-f092bb439071', N'a4360e7a-a578-4af7-a305-df20726eef14', N'AdresseUpdt', N'AdresseUpdt'),
    (N'6b301ee8-22d8-4890-a2d0-00fe41a882df', N'25176a29-748e-45aa-807e-ab9bb1def50b', N'AdresseRead', N'AdresseRead'),
    (N'605db567-0072-4fae-b32e-37192aa57dbf', N'54fd8058-9129-405e-a9cb-e7f97162aead', N'AdresseCreat', N'AdresseCreat'),
    (N'35cd68f3-7fbe-43e6-9681-4f356e9a5f45', N'0e539161-c3dd-4473-951d-5e778274f392', N'AgenceDlet', N'AgenceDlet'),
    (N'3c299db1-2c54-4a6d-a5b8-968f7ea1b017', N'3c21cc10-1f80-48ae-aa00-45bb2a5463bd', N'AgenceUpdt', N'AgenceUpdt'),
    (N'7e52f5ce-056e-4963-bbea-9e85abfdf140', N'c5466864-77d4-4f62-bcbd-672e9db6b021', N'AgenceRead', N'AgenceRead'),
    (N'd42ad489-13cc-44a5-ad14-2ea980f26e52', N'54d86890-79e2-4ab9-bda3-6a4a2e67ac5d', N'AgenceCreat', N'AgenceCreat'),
    (N'2a88db49-2931-41f3-b03b-8124420de987', N'ac5ff6ff-48ca-4694-bf46-cbf596a078cb', N'ZoneDlet', N'ZoneDlet'),
    (N'0539982b-449a-42a5-ba85-340b1a46dca4', N'58d10ec1-ae04-4887-b674-b72d06485079', N'ZoneUpdt', N'ZoneUpdt'),
    (N'0387338c-c618-49bd-ac3f-552b70fd0790', N'53fdb4d1-841b-4474-a3d9-dd015cd4331f', N'ZoneRead', N'ZoneRead'),
    (N'ea0caa4b-3b40-46ac-9ff9-eb81b5e4d455', N'aac302ab-e5d4-480c-8e73-9ee2e39f2fc7', N'ZoneCreat', N'ZoneCreat'),
    (N'11b03500-7f50-4e9c-b489-7b7475f8df62', N'7f568a63-aba6-4079-9205-885bc98449a6', N'SondageDlet', N'SondageDlet'),
    (N'3c29eb8a-5fec-463a-8f71-5f7a753afec1', N'a57d7bab-c026-4f7b-a1ce-abde18d0b283', N'SondageUpdt', N'SondageUpdt'),
    (N'3e757a24-33f0-4754-9cbe-e78e3923ccf0', N'e057e051-7e9c-46e5-bbb3-5e7f40764410', N'SondageRead', N'SondageRead'),
    (N'3c03b439-7316-48e7-8865-3f261c075a72', N'3f16b1de-5b05-4d50-9661-d8e64fa3689a', N'SondageCreat', N'SondageCreat'),
    (N'd171c020-2e65-43c8-9bd2-351c90c9f906', N'716eea5e-b985-4be8-a5fd-329c07eb8ef0', N'VehiculeDlet', N'VehiculeDlet'),
    (N'a8614a1f-55cf-4b2d-9d74-6da7af8e988a', N'6369c1a5-fc8f-4228-b816-9c2eba451574', N'VehiculeUpdt', N'VehiculeUpdt'),
    (N'5a21b337-54df-44af-b76d-36a89a0b1203', N'19f3e9a3-0936-4518-b907-0e2180def9db', N'VehiculeRead', N'VehiculeRead'),
    (N'3f69bebd-4203-4b0f-962f-1eccdc163074', N'd17b65a8-a19a-4d0c-b498-ed0debc76802', N'VehiculeCreat', N'VehiculeCreat'),
    (N'ac5d9389-c11b-46c9-b6c4-ec278128fb8c', N'bbb16680-ac5a-4d86-bd5b-1cd80af6e4fe', N'TourneeDlet', N'TourneeDlet');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[IdentityRole]'))
        SET IDENTITY_INSERT [IdentityRole] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[IdentityUser]'))
        SET IDENTITY_INSERT [IdentityUser] ON;
    INSERT INTO [IdentityUser] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
    VALUES (N'43592427-a291-46be-8cf9-a89314b496dc', 0, N'cd4ca31c-cb33-4125-a9d4-4264a6605768', N'admin@forcetracking.com', CAST(0 AS bit), CAST(1 AS bit), NULL, N'ADMIN@FORCETRACKING.COM', N'ADMINISTRATEUR', N'AQAAAAEAACcQAAAAEKdFzfYr+/auZG9ALdHQjbqWuqK/OpNNYlh2bCE51Rdb4LAikdJ3tSyKJhiFD3/6Cg==', N'', CAST(0 AS bit), N'Y2LK2XCOM4FDYBMT76ROIFBOJXCBK2IL', CAST(0 AS bit), N'administrateur');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[IdentityUser]'))
        SET IDENTITY_INSERT [IdentityUser] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223200440_iden')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191223200440_iden', N'3.1.0');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223210339_iden1')
BEGIN
    DROP TABLE [IdentityRole];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223210339_iden1')
BEGIN
    DROP TABLE [IdentityUser];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223210339_iden1')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
        SET IDENTITY_INSERT [AspNetRoles] ON;
    INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
    VALUES (N'69c2620c-5b13-47d3-9f5e-fff5370bd8c2', N'81c9403b-d4cd-4edb-8929-440aad2ae209', N'Admin', N'ADMIN'),
    (N'1b794e51-8266-47d2-bb24-7ecf71852c36', N'd47ae7e8-efd7-4c01-a77c-25ef78cbeda6', N'TourneeUpdt', N'TourneeUpdt'),
    (N'058ac7fe-6e0c-4791-aea9-7e490e19f43b', N'a6cd5701-be32-4662-a8e4-590f228e0038', N'TourneeRead', N'TourneeRead'),
    (N'42809b08-20d2-407b-b195-b249170bd214', N'a5aaa19d-1dfd-4338-9703-47d6ab0a73fd', N'TourneeCreat', N'TourneeCreat'),
    (N'ce6ac039-3339-417d-8496-9166c0e2a5df', N'7a43292d-e25a-48ae-8573-5ba46000fa63', N'CourseDlet', N'CourseDlet'),
    (N'1e9daf8c-4c68-46ca-9050-cd172d233fb5', N'799fdb6f-150c-4390-8c67-18e0774afc3e', N'CourseUpdt', N'CourseUpdt'),
    (N'7b172b78-5904-4947-aa06-1086a8257673', N'56228f11-6669-47bb-896a-9314b431459d', N'CourseRead', N'CourseRead'),
    (N'be82510e-97c1-44ef-95b9-3cb1a8f1bad3', N'd0d3aa62-0767-41fe-988f-5ef8d2418f87', N'CourseCreat', N'CourseCreat'),
    (N'40f46f9c-b0bb-4580-b910-3446209bf317', N'd8e543e2-933f-4d51-a959-f60aadf04f05', N'AdresseDlet', N'AdresseDlet'),
    (N'1d2a9f13-8e1b-44c8-81f2-1f7e76ce974d', N'36e0c674-0800-4480-909e-0f96a52264f0', N'AdresseUpdt', N'AdresseUpdt'),
    (N'037a1502-76d7-45cc-a7c5-79e0c8fe2291', N'6fa980da-d17f-4608-88b5-7386af329ac9', N'AdresseRead', N'AdresseRead'),
    (N'9d13d7b1-4304-4b3c-a347-16994952ee21', N'63aa0863-af2c-4465-9245-73ec84d10f81', N'AdresseCreat', N'AdresseCreat'),
    (N'b5545546-10e1-4625-ad10-6daf8c37848a', N'5ef2e343-4ec7-42c4-b6c7-bdfb44cbcb99', N'AgenceDlet', N'AgenceDlet'),
    (N'313e8ee5-84a6-495d-9ebf-79e7129b2fff', N'3f507399-a42b-4dad-8d3e-f561f9721685', N'AgenceUpdt', N'AgenceUpdt'),
    (N'0044889a-e7d7-4b58-a128-1675638a83a2', N'207ca19d-2c9a-4756-8854-d8cf39176c4a', N'AgenceRead', N'AgenceRead'),
    (N'fb0db5ea-8474-418e-aaa4-0f35a126f97c', N'b77a1ec7-bf70-4bb7-8998-fc9d904c2932', N'AgenceCreat', N'AgenceCreat'),
    (N'376f6768-fd8a-49d7-b5c1-991fe1d6d700', N'd863d05e-06ae-4b74-8622-cd8bbd065c8c', N'ZoneDlet', N'ZoneDlet'),
    (N'e710f164-f5ee-409f-bf4c-0e8eb7f86faa', N'0ae662eb-3a77-49e6-8cc0-dff36d783816', N'ZoneUpdt', N'ZoneUpdt'),
    (N'a7c94eae-d5f7-4de1-8a4e-35e6966e93e0', N'bb99b0dd-ab37-4b50-ab58-3c23093faebe', N'ZoneRead', N'ZoneRead'),
    (N'7b6a59f4-47e5-4779-89d9-506828955e0a', N'abd6dacc-395a-4d51-bb5a-d6b6c3511807', N'ZoneCreat', N'ZoneCreat'),
    (N'c92c7326-d847-4e38-963d-47377d5651d8', N'39ba1ce5-c669-4eab-97ac-15af69dd32d8', N'SondageDlet', N'SondageDlet'),
    (N'8d0d3cb6-c823-43d6-9c86-ba0217198f32', N'4eeddb68-3eba-40fc-9141-e39e8a5a18ad', N'SondageUpdt', N'SondageUpdt'),
    (N'efbb2427-b17f-43ca-be5b-b5ce00ca96eb', N'9a404fe4-bc20-46ae-b707-0bac1874dd96', N'SondageRead', N'SondageRead'),
    (N'80aeb289-858a-4e17-be4c-bf2665162068', N'da09a1e8-eb18-44d2-acb2-0dd7242523c3', N'SondageCreat', N'SondageCreat'),
    (N'207562aa-bfe6-475d-b9eb-c0e0600704ed', N'1e77cd9d-a17a-4965-887a-3c84dade92f6', N'VehiculeDlet', N'VehiculeDlet'),
    (N'c3d82a71-c0cd-4420-adb1-225e349e14a9', N'0779906f-ea2b-416a-9f2d-0ab7129af866', N'VehiculeUpdt', N'VehiculeUpdt'),
    (N'cb50b92d-417c-443c-b06d-e245cda807ed', N'62b7839d-9c1b-40eb-8f6c-4b162916bd35', N'VehiculeRead', N'VehiculeRead'),
    (N'4d9e7d2d-65ed-4620-8898-c4bfe8600e63', N'5b342b11-13ee-4221-8b4d-c161f663996f', N'VehiculeCreat', N'VehiculeCreat'),
    (N'0ade0a90-9403-42f9-b4f9-318383d06980', N'c601287b-c2ea-42d5-b76b-290d719a09bc', N'TourneeDlet', N'TourneeDlet');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
        SET IDENTITY_INSERT [AspNetRoles] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223210339_iden1')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
        SET IDENTITY_INSERT [AspNetUsers] ON;
    INSERT INTO [AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
    VALUES (N'7d392424-e2c6-434b-ac49-9bb33e8293be', 0, N'cd4ca31c-cb33-4125-a9d4-4264a6605768', N'admin@forcetracking.com', CAST(0 AS bit), CAST(1 AS bit), NULL, N'ADMIN@FORCETRACKING.COM', N'ADMINISTRATEUR', N'AQAAAAEAACcQAAAAEKdFzfYr+/auZG9ALdHQjbqWuqK/OpNNYlh2bCE51Rdb4LAikdJ3tSyKJhiFD3/6Cg==', N'', CAST(0 AS bit), N'Y2LK2XCOM4FDYBMT76ROIFBOJXCBK2IL', CAST(0 AS bit), N'administrateur');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
        SET IDENTITY_INSERT [AspNetUsers] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191223210339_iden1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191223210339_iden1', N'3.1.0');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'01eb0c02-cac6-43f6-a07b-03fe8f6a5a2a';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'093c7e83-9ce6-4ce9-a4ce-f7beee924ee5';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'09e1a27f-3287-4daf-b9ff-910135be58f4';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'147b1761-3114-44e2-8504-62010c7a1481';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'1ee98e5d-d636-4117-9537-b32fd8bd1374';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'31e0d721-94ba-43d2-874d-a45beee884bf';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'33b7aaa6-6718-4ba3-a138-828ba28972f7';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'3483bf12-7395-49ea-8d17-0c89dd7ec0fb';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'3ba57626-6a90-4459-abbe-188e41b73d91';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'41856507-b2a4-42ea-99b7-94cf396f0c36';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'4401f048-782d-4471-a4c9-f60510d9ac1f';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'48d679f7-9953-4d1a-b33e-8100f2d5e560';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'52a4d577-dac0-4d36-976b-80f892ed97eb';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'53b471ba-7053-4d1b-9fc8-f36cbcfa8cd0';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'53cb97bd-4289-48cf-8527-f38c7a6678b6';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'5c5992dc-a493-41a7-8369-80fa80d8cf2e';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'779f708f-56a2-4483-9e7c-63f2bf910cd9';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'999b4fcb-fc79-47e0-b09e-f81b335617f6';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'9e80623f-68e8-4a93-a45b-1535f5be2663';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'a00a2fcf-495a-4ff0-bbec-95305a395e49';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'a09b197e-666f-48b8-a02b-bef752723df3';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'a1717271-5dad-4dfb-8824-50a5c8954c09';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'a8e59641-c4bc-422e-9eec-ff712e772001';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'af7b3e3a-cec6-47b7-912c-7327be558003';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'b8b7be73-b0d5-4359-8b11-a7008141661c';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'bfe93425-594a-4f1f-9a88-685148302021';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'debb4d0a-28f2-4884-a537-8f66f6fff4a2';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'f7babf98-b14e-4944-aee1-254b15ca3708';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetRoles]
    WHERE [Id] = N'ff4f6fd8-f22d-4568-bdd4-05eeb4f1a80d';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    DELETE FROM [AspNetUsers]
    WHERE [Id] = N'806edb29-9623-435c-9d2c-8b9629bf8349';
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111114441_latlng')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200111114441_latlng', N'3.1.0');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111115443_remadr')
BEGIN
    DROP TABLE [Adresse];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111115443_remadr')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200111115443_remadr', N'3.1.0');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111120201_addadr')
BEGIN
    CREATE TABLE [Adresse] (
        [AdresseId] int NOT NULL IDENTITY,
        [Societé] nvarchar(max) NOT NULL,
        [Nom] nvarchar(max) NOT NULL,
        [Prenom] nvarchar(max) NULL,
        [Telephone] int NOT NULL,
        [Email] nvarchar(max) NULL,
        [Adress] nvarchar(max) NOT NULL,
        [Ville] nvarchar(max) NOT NULL,
        [Codepostale] int NOT NULL,
        [Latitude] float NOT NULL,
        [Longitude] float NOT NULL,
        [Agenceid] int NOT NULL,
        [Commentaire] nvarchar(max) NULL,
        [Type] nvarchar(max) NULL,
        CONSTRAINT [PK_Adresse] PRIMARY KEY ([AdresseId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200111120201_addadr')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200111120201_addadr', N'3.1.0');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200114173809_st')
BEGIN
    CREATE TABLE [Familleproduit] (
        [FamilleproduitId] int NOT NULL IDENTITY,
        [Libellé] nvarchar(max) NULL,
        CONSTRAINT [PK_Familleproduit] PRIMARY KEY ([FamilleproduitId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200114173809_st')
BEGIN
    CREATE TABLE [JournalStock] (
        [JournalStockId] int NOT NULL IDENTITY,
        [ProduitId] int NOT NULL,
        [Date] datetime2 NOT NULL,
        [Qte] int NOT NULL,
        [Motif] nvarchar(max) NULL,
        CONSTRAINT [PK_JournalStock] PRIMARY KEY ([JournalStockId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200114173809_st')
BEGIN
    CREATE TABLE [JournalStockV] (
        [JournalStockVId] int NOT NULL IDENTITY,
        [ProduitId] int NOT NULL,
        [Date] datetime2 NOT NULL,
        [Qte] int NOT NULL,
        [Motif] nvarchar(max) NULL,
        CONSTRAINT [PK_JournalStockV] PRIMARY KEY ([JournalStockVId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200114173809_st')
BEGIN
    CREATE TABLE [Produit] (
        [ProduitId] int NOT NULL IDENTITY,
        [CodeArticle] nvarchar(max) NULL,
        [Designation] nvarchar(max) NULL,
        [Prix] float NOT NULL,
        [TypeproduitId] int NOT NULL,
        [FamilleproduitId] int NOT NULL,
        CONSTRAINT [PK_Produit] PRIMARY KEY ([ProduitId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200114173809_st')
BEGIN
    CREATE TABLE [Quantite] (
        [QuantiteId] int NOT NULL IDENTITY,
        [Qte] int NOT NULL,
        [ProduitId] int NOT NULL,
        CONSTRAINT [PK_Quantite] PRIMARY KEY ([QuantiteId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200114173809_st')
BEGIN
    CREATE TABLE [StockInterne] (
        [StockId] int NOT NULL IDENTITY,
        [ProduitId] int NOT NULL,
        [Quantite] int NOT NULL,
        CONSTRAINT [PK_StockInterne] PRIMARY KEY ([StockId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200114173809_st')
BEGIN
    CREATE TABLE [StockVehicule] (
        [StockVId] int NOT NULL IDENTITY,
        [VehiculeId] int NOT NULL,
        [ProduitId] int NOT NULL,
        [Qte] int NOT NULL,
        CONSTRAINT [PK_StockVehicule] PRIMARY KEY ([StockVId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200114173809_st')
BEGIN
    CREATE TABLE [Typeproduit] (
        [TypeproduitId] int NOT NULL IDENTITY,
        [Libellé] nvarchar(max) NULL,
        CONSTRAINT [PK_Typeproduit] PRIMARY KEY ([TypeproduitId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200114173809_st')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200114173809_st', N'3.1.0');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200115154554_stp')
BEGIN
    DECLARE @var18 sysname;
    SELECT @var18 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[StockInterne]') AND [c].[name] = N'ProduitId');
    IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [StockInterne] DROP CONSTRAINT [' + @var18 + '];');
    ALTER TABLE [StockInterne] ALTER COLUMN [ProduitId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200115154554_stp')
BEGIN
    CREATE INDEX [IX_StockInterne_ProduitId] ON [StockInterne] ([ProduitId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200115154554_stp')
BEGIN
    ALTER TABLE [StockInterne] ADD CONSTRAINT [FK_StockInterne_Produit_ProduitId] FOREIGN KEY ([ProduitId]) REFERENCES [Produit] ([ProduitId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200115154554_stp')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200115154554_stp', N'3.1.0');
END;

GO


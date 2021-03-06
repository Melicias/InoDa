
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/22/2018 20:16:20
-- Generated from EDMX file: C:\Users\melic\Desktop\trabalhos\desenvolvimento de aplicacoes\projeto final\projeto_final_InoDa\projeto_final_InoDa\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BDimoda];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ArrendamentoCasaArrendavel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArrendamentoSet] DROP CONSTRAINT [FK_ArrendamentoCasaArrendavel];
GO
IF OBJECT_ID(N'[dbo].[FK_ArrendamentoCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArrendamentoSet] DROP CONSTRAINT [FK_ArrendamentoCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VendaSet] DROP CONSTRAINT [FK_VendaCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaCasaVendavel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VendaSet] DROP CONSTRAINT [FK_VendaCasaVendavel];
GO
IF OBJECT_ID(N'[dbo].[FK_LimpezaCasa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LimpezaSet] DROP CONSTRAINT [FK_LimpezaCasa];
GO
IF OBJECT_ID(N'[dbo].[FK_ServicoLimpeza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServicoSet] DROP CONSTRAINT [FK_ServicoLimpeza];
GO
IF OBJECT_ID(N'[dbo].[FK_CasaCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CasaSet] DROP CONSTRAINT [FK_CasaCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_CasaArrendavel_inherits_Casa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CasaSet_CasaArrendavel] DROP CONSTRAINT [FK_CasaArrendavel_inherits_Casa];
GO
IF OBJECT_ID(N'[dbo].[FK_CasaVendavel_inherits_Casa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CasaSet_CasaVendavel] DROP CONSTRAINT [FK_CasaVendavel_inherits_Casa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ClienteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClienteSet];
GO
IF OBJECT_ID(N'[dbo].[VendaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VendaSet];
GO
IF OBJECT_ID(N'[dbo].[CasaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CasaSet];
GO
IF OBJECT_ID(N'[dbo].[LimpezaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LimpezaSet];
GO
IF OBJECT_ID(N'[dbo].[ServicoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServicoSet];
GO
IF OBJECT_ID(N'[dbo].[ArrendamentoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArrendamentoSet];
GO
IF OBJECT_ID(N'[dbo].[CasaSet_CasaArrendavel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CasaSet_CasaArrendavel];
GO
IF OBJECT_ID(N'[dbo].[CasaSet_CasaVendavel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CasaSet_CasaVendavel];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClienteSet'
CREATE TABLE [dbo].[ClienteSet] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [NIF] bigint  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Contacto] bigint  NOT NULL
);
GO

-- Creating table 'VendaSet'
CREATE TABLE [dbo].[VendaSet] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [DataVenda] datetime  NOT NULL,
    [ValorNegociado] float  NOT NULL,
    [ComissaoNegociada] float  NOT NULL,
    [Comprador_IdCliente] int  NOT NULL,
    [CasaVendavel_IdCasa] int  NOT NULL
);
GO

-- Creating table 'CasaSet'
CREATE TABLE [dbo].[CasaSet] (
    [IdCasa] int IDENTITY(1,1) NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [Andar] nvarchar(max)  NOT NULL,
    [Area] nvarchar(max)  NOT NULL,
    [NumeroAssoalhada] int  NOT NULL,
    [NumeroWC] int  NOT NULL,
    [NumeroPisos] int  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Proprietario_IdCliente] int  NOT NULL
);
GO

-- Creating table 'LimpezaSet'
CREATE TABLE [dbo].[LimpezaSet] (
    [IdLimpeza] int IDENTITY(1,1) NOT NULL,
    [Data] datetime  NOT NULL,
    [Casa_IdCasa] int  NULL
);
GO

-- Creating table 'ServicoSet'
CREATE TABLE [dbo].[ServicoSet] (
    [IdServico] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Valor] float  NOT NULL,
    [Unidades] float  NOT NULL,
    [Limpeza_IdLimpeza] int  NULL
);
GO

-- Creating table 'ArrendamentoSet'
CREATE TABLE [dbo].[ArrendamentoSet] (
    [IdArrendamento] int IDENTITY(1,1) NOT NULL,
    [InicioContrato] datetime  NOT NULL,
    [DuracaoMeses] int  NOT NULL,
    [Renovavel] bit  NOT NULL,
    [CasaArrendavel_IdCasa] int  NULL,
    [Cliente_IdCliente] int  NOT NULL
);
GO

-- Creating table 'CasaSet_CasaArrendavel'
CREATE TABLE [dbo].[CasaSet_CasaArrendavel] (
    [ValorBaseMes] float  NOT NULL,
    [Comissao] float  NOT NULL,
    [IdCasa] int  NOT NULL
);
GO

-- Creating table 'CasaSet_CasaVendavel'
CREATE TABLE [dbo].[CasaSet_CasaVendavel] (
    [ValorBaseVenda] float  NOT NULL,
    [ValorComissao] float  NOT NULL,
    [IdCasa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCliente] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [PK_ClienteSet]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- Creating primary key on [IdVenda] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [PK_VendaSet]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

-- Creating primary key on [IdCasa] in table 'CasaSet'
ALTER TABLE [dbo].[CasaSet]
ADD CONSTRAINT [PK_CasaSet]
    PRIMARY KEY CLUSTERED ([IdCasa] ASC);
GO

-- Creating primary key on [IdLimpeza] in table 'LimpezaSet'
ALTER TABLE [dbo].[LimpezaSet]
ADD CONSTRAINT [PK_LimpezaSet]
    PRIMARY KEY CLUSTERED ([IdLimpeza] ASC);
GO

-- Creating primary key on [IdServico] in table 'ServicoSet'
ALTER TABLE [dbo].[ServicoSet]
ADD CONSTRAINT [PK_ServicoSet]
    PRIMARY KEY CLUSTERED ([IdServico] ASC);
GO

-- Creating primary key on [IdArrendamento] in table 'ArrendamentoSet'
ALTER TABLE [dbo].[ArrendamentoSet]
ADD CONSTRAINT [PK_ArrendamentoSet]
    PRIMARY KEY CLUSTERED ([IdArrendamento] ASC);
GO

-- Creating primary key on [IdCasa] in table 'CasaSet_CasaArrendavel'
ALTER TABLE [dbo].[CasaSet_CasaArrendavel]
ADD CONSTRAINT [PK_CasaSet_CasaArrendavel]
    PRIMARY KEY CLUSTERED ([IdCasa] ASC);
GO

-- Creating primary key on [IdCasa] in table 'CasaSet_CasaVendavel'
ALTER TABLE [dbo].[CasaSet_CasaVendavel]
ADD CONSTRAINT [PK_CasaSet_CasaVendavel]
    PRIMARY KEY CLUSTERED ([IdCasa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CasaArrendavel_IdCasa] in table 'ArrendamentoSet'
ALTER TABLE [dbo].[ArrendamentoSet]
ADD CONSTRAINT [FK_ArrendamentoCasaArrendavel]
    FOREIGN KEY ([CasaArrendavel_IdCasa])
    REFERENCES [dbo].[CasaSet_CasaArrendavel]
        ([IdCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArrendamentoCasaArrendavel'
CREATE INDEX [IX_FK_ArrendamentoCasaArrendavel]
ON [dbo].[ArrendamentoSet]
    ([CasaArrendavel_IdCasa]);
GO

-- Creating foreign key on [Cliente_IdCliente] in table 'ArrendamentoSet'
ALTER TABLE [dbo].[ArrendamentoSet]
ADD CONSTRAINT [FK_ArrendamentoCliente]
    FOREIGN KEY ([Cliente_IdCliente])
    REFERENCES [dbo].[ClienteSet]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArrendamentoCliente'
CREATE INDEX [IX_FK_ArrendamentoCliente]
ON [dbo].[ArrendamentoSet]
    ([Cliente_IdCliente]);
GO

-- Creating foreign key on [Comprador_IdCliente] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [FK_VendaCliente]
    FOREIGN KEY ([Comprador_IdCliente])
    REFERENCES [dbo].[ClienteSet]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaCliente'
CREATE INDEX [IX_FK_VendaCliente]
ON [dbo].[VendaSet]
    ([Comprador_IdCliente]);
GO

-- Creating foreign key on [CasaVendavel_IdCasa] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [FK_VendaCasaVendavel]
    FOREIGN KEY ([CasaVendavel_IdCasa])
    REFERENCES [dbo].[CasaSet_CasaVendavel]
        ([IdCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaCasaVendavel'
CREATE INDEX [IX_FK_VendaCasaVendavel]
ON [dbo].[VendaSet]
    ([CasaVendavel_IdCasa]);
GO

-- Creating foreign key on [Casa_IdCasa] in table 'LimpezaSet'
ALTER TABLE [dbo].[LimpezaSet]
ADD CONSTRAINT [FK_LimpezaCasa]
    FOREIGN KEY ([Casa_IdCasa])
    REFERENCES [dbo].[CasaSet]
        ([IdCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LimpezaCasa'
CREATE INDEX [IX_FK_LimpezaCasa]
ON [dbo].[LimpezaSet]
    ([Casa_IdCasa]);
GO

-- Creating foreign key on [Limpeza_IdLimpeza] in table 'ServicoSet'
ALTER TABLE [dbo].[ServicoSet]
ADD CONSTRAINT [FK_ServicoLimpeza]
    FOREIGN KEY ([Limpeza_IdLimpeza])
    REFERENCES [dbo].[LimpezaSet]
        ([IdLimpeza])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicoLimpeza'
CREATE INDEX [IX_FK_ServicoLimpeza]
ON [dbo].[ServicoSet]
    ([Limpeza_IdLimpeza]);
GO

-- Creating foreign key on [Proprietario_IdCliente] in table 'CasaSet'
ALTER TABLE [dbo].[CasaSet]
ADD CONSTRAINT [FK_CasaCliente]
    FOREIGN KEY ([Proprietario_IdCliente])
    REFERENCES [dbo].[ClienteSet]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CasaCliente'
CREATE INDEX [IX_FK_CasaCliente]
ON [dbo].[CasaSet]
    ([Proprietario_IdCliente]);
GO

-- Creating foreign key on [IdCasa] in table 'CasaSet_CasaArrendavel'
ALTER TABLE [dbo].[CasaSet_CasaArrendavel]
ADD CONSTRAINT [FK_CasaArrendavel_inherits_Casa]
    FOREIGN KEY ([IdCasa])
    REFERENCES [dbo].[CasaSet]
        ([IdCasa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCasa] in table 'CasaSet_CasaVendavel'
ALTER TABLE [dbo].[CasaSet_CasaVendavel]
ADD CONSTRAINT [FK_CasaVendavel_inherits_Casa]
    FOREIGN KEY ([IdCasa])
    REFERENCES [dbo].[CasaSet]
        ([IdCasa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
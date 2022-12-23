CREATE DATABASE [he_dados]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'he_dados', FILENAME = N'%userprofile%\he_db\he_dados.mdf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'he_dados_log', FILENAME = N'%userprofile%\he_db\he_dados_log.ldf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [he_dados] SET COMPATIBILITY_LEVEL = 130
GO
ALTER DATABASE [he_dados] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [he_dados] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [he_dados] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [he_dados] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [he_dados] SET ARITHABORT OFF 
GO
ALTER DATABASE [he_dados] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [he_dados] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [he_dados] SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF)
GO
ALTER DATABASE [he_dados] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [he_dados] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [he_dados] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [he_dados] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [he_dados] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [he_dados] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [he_dados] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [he_dados] SET  DISABLE_BROKER 
GO
ALTER DATABASE [he_dados] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [he_dados] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [he_dados] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [he_dados] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [he_dados] SET  READ_WRITE 
GO
ALTER DATABASE [he_dados] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [he_dados] SET  MULTI_USER 
GO
ALTER DATABASE [he_dados] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [he_dados] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [he_dados] SET DELAYED_DURABILITY = DISABLED 
GO
USE [he_dados]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = Off;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = Primary;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = On;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = Primary;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = Off;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = Primary;
GO
USE [he_dados]
GO
IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [he_dados] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO
CREATE TABLE [dbo].[Cliente]
(
	[IDCliente] INT NOT NULL PRIMARY KEY identity(1,1),
	[Nome] varchar(50) not null, 
    [Rg] VARCHAR(12) NOT NULL, 
    [Cpf] VARCHAR(14) NOT NULL, 
    [Celular] VARCHAR(16) NULL, 
    [Telefone] VARCHAR(14) NULL, 
    [DataNascimento] DATE NOT NULL, 
    [Endereco] VARCHAR(80) NULL, 
    [Bairro] VARCHAR(30) NULL, 
    [Cidade] VARCHAR(40) NULL, 
    [Uf] VARCHAR(2) NULL, 
    [Cep] VARCHAR(9) NULL, 
    [Observacao] VARCHAR(MAX) NULL,
)
CREATE TABLE [dbo].[Hospedagem]
(
	[IDHospedagem] INT NOT NULL PRIMARY KEY, 
    [DataEntrada] DATE NOT NULL, 
    [DataSaida] DATE NULL, 
    [DataSaidaPrevista] DATE NULL, 
    [ValorHosp] MONEY NOT NULL, 
    [DataVencePag] DATE NULL, 
    [FK_IDTipoHosp] INT NOT NULL, 
    [FK_IDCliente] INT NOT NULL, 
    [FK_IDQuarto] INT NOT NULL
)
CREATE TABLE [dbo].[Quarto]
(
	[IDQuarto] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [TemTV] bit NOT NULL, 
    [Vagas] INT NOT NULL, 
    [Descricao] VARCHAR(50) NULL
)
CREATE TABLE [dbo].[Dependente]
(
	[FK_IDCliente] INT NOT NULL, 
    [FK_IDHospedagem] INT NOT NULL, 
    [Nome] VARCHAR(50) NOT NULL, 
    [Idade] INT NULL, 
    [Parentesco] VARCHAR(12) NULL 
)
CREATE TABLE [dbo].[Pagamento]
(
	[IDPagamento] INT NOT NULL PRIMARY KEY, 
    [DataPagamento] DATE NOT NULL, 
    [FK_IDHospedagem] INT NOT NULL, 
    [FK_EstadoPag] INT NOT NULL, 
    [FK_OpcaoPag] INT NOT NULL, 
    [FK_TipoHosp] INT NOT NULL
)
CREATE TABLE [dbo].[EstadoPagamento]
(
	[IDEstadoPag] INT NOT NULL PRIMARY KEY, 
    [Descricao] VARCHAR(12) NOT NULL
)
CREATE TABLE [dbo].[TipoHospedagem]
(
	[IDTipoHosp] INT NOT NULL PRIMARY KEY, 
    [Descricao] VARCHAR(12) NOT NULL
)
create table OpcaoPag (
	IDOpcaoPag		int  primary key not null identity (1,1),
	Descricao	varchar(12) not null
);
--Tabela Dependente FK's
alter table Dependente
add constraint FK_IDCLiente_em_Dep foreign key(FK_IDCliente) 
references Cliente(IDCliente);

alter table Dependente
add constraint FK_IDHospedagem_em_Dep foreign key (FK_IDHospedagem)
references Hospedagem(IDHospedagem);

--Tabela Hospedagem FK's
alter table Hospedagem
add constraint FK_IDTipoHosp_em_Hosp foreign key(FK_IDTipoHosp)
references TipoHospedagem(IDTipoHosp)

alter table Hospedagem
add constraint FK_IDCliente_em_Hosp foreign key(FK_IDCLiente)
references Cliente(IDCliente);

alter table Hospedagem
add constraint FK_IDQuarto_em_Hosp foreign key(FK_IDQuarto)
references Quarto(IDQuarto);

--Tabela Pagamentos FK's
alter table Pagamento
add constraint FK_IDHospedagem_em_Pag foreign key(FK_IDHospedagem)
references Hospedagem(IDHospedagem);

alter table Pagamento
add constraint FK_EstadoPag_em_Pag foreign key(FK_EstadoPag)
references EstadoPagamento(IDEstadoPag);

alter table Pagamento
add constraint FK_OpcaoPag_em_Pag foreign key(FK_OpcaoPag)
references OpcaoPag(IDOpcaoPag);

alter table Pagamento
add constraint FK_TipoHosp_em_Pag foreign key(FK_TipoHosp)
references TipoHospedagem(IDTipoHosp);



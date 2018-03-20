USE [master]
GO
--NOTE Change the Filename depending on your PC / preferences 
CREATE DATABASE [TestStories]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TestStories', FILENAME = N'C:\Users\james.hood\TestStories.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TestStories_log', FILENAME = N'C:\Users\james.hood\TestStories_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TestStories].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [TestStories] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [TestStories] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [TestStories] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [TestStories] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [TestStories] SET ARITHABORT OFF 
GO

ALTER DATABASE [TestStories] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [TestStories] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [TestStories] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [TestStories] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [TestStories] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [TestStories] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [TestStories] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [TestStories] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [TestStories] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [TestStories] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [TestStories] SET  DISABLE_BROKER 
GO

ALTER DATABASE [TestStories] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [TestStories] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [TestStories] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [TestStories] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [TestStories] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [TestStories] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [TestStories] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [TestStories] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [TestStories] SET  MULTI_USER 
GO

ALTER DATABASE [TestStories] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [TestStories] SET DB_CHAINING OFF 
GO

ALTER DATABASE [TestStories] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [TestStories] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [TestStories] SET  READ_WRITE 
GO

--Creation script for Testing
IF (NOT EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'TestStories' 
                 AND  TABLE_NAME = 'Stories'))
BEGIN
	CREATE TABLE Stories
	(
		 StoryId INT IDENTITY(1,1)
		,StoryTitle VARCHAR(50) NULL
		,PRIMARY KEY (StoryId)
	);

	INSERT INTO 
		Stories (StoryTitle)
	VALUES
		('Test Story')
END

IF (NOT EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'TestStories' 
                 AND  TABLE_NAME = 'Conversations'))
BEGIN
	CREATE TABLE Conversations
	(
		 ConversationId INT IDENTITY(1,1)
		,ConversationText NVARCHAR(MAX)
		,StoryId INT
		,PRIMARY KEY (ConversationId)
		,FOREIGN KEY (StoryId) REFERENCES Stories(StoryId)
	);
	INSERT INTO
		Conversations (StoryId, ConversationText)
	VALUES 
		(1, 'Hey there, you look a little lost...')
	INSERT INTO
		Conversations (StoryId, ConversationText)
	VALUES 
		(1, 'To be honest with you I dont know half the time,Would you like to find the key to the secret?')

END
IF (NOT EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'TestStories' 
                 AND  TABLE_NAME = 'ConversationOptions'))
BEGIN
	CREATE TABLE ConversationOptions
	(
		 ConversationOptionId INT IDENTITY(1,1)
		,ConversationId INT 
		,ConversationOptionText NVARCHAR(MAX)
		,FOREIGN KEY(ConversationId) REFERENCES Conversations(ConversationId)
		,PRIMARY KEY(ConversationOptionId)
	);

	INSERT INTO 
		ConversationOptions (ConversationId, ConversationOptionText)
	VALUES 
		(1, 'Who are you?')
	INSERT INTO 
		ConversationOptions (ConversationId, ConversationOptionText)
	VALUES 
		(1, 'Where am I?')
	INSERT INTO 
		ConversationOptions (ConversationId, ConversationOptionText)
	VALUES 
		(1, 'You look lost!')

	INSERT INTO 
		ConversationOptions (ConversationId, ConversationOptionText)
	VALUES 
		(2, 'What secret, what are you talking about?')
	INSERT INTO 
		ConversationOptions (ConversationId, ConversationOptionText)
	VALUES 
		(2, 'Yes tell me how to find the key')
	INSERT INTO 
		ConversationOptions (ConversationId, ConversationOptionText)
	VALUES 
		(2, 'I have no idea what you''re talking about')
END
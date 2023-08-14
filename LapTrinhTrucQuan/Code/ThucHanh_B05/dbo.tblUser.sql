CREATE TABLE [dbo].[tblUser] (
    [UserName] NVARCHAR (50) NOT NULL,
    [Password] NVARCHAR(20)        NULL,
    [Quyen]    NVARCHAR(10)         NULL,
    CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED ([UserName] ASC)
);


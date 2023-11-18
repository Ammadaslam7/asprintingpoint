-- Create the User table
CREATE TABLE [User] (
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(255),
    Email NVARCHAR(255),
    AccountType NVARCHAR(50),
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    Active BIT DEFAULT 1
);

-- Create the OAuthToken table
CREATE TABLE OAuthToken (
    TokenID INT PRIMARY KEY IDENTITY,
    UserID INT,
    Token NVARCHAR(500), -- Store OAuth tokens as per your provider's specifications
    TokenType NVARCHAR(50), -- e.g., Bearer Token, OAuth 2.0
    ExpiresAt DATETIME, -- Token expiration date and time
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    Active BIT DEFAULT 1,
    FOREIGN KEY (UserID) REFERENCES [User](UserID)
);

-- Create the Category table
CREATE TABLE Category (
    CategoryID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(255),
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    Active BIT DEFAULT 1
);

-- Create the Product table
CREATE TABLE Product (
    ProductID INT PRIMARY KEY IDENTITY,
    CategoryID INT,
    Name NVARCHAR(255),
    Description NVARCHAR(MAX),
    Price DECIMAL(10, 2),
    Stock INT,
    Purchaseable BIT DEFAULT 1,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    Active BIT DEFAULT 1,
    FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
);

-- Create the ProductImage table
CREATE TABLE ProductImage (
    ImageID INT PRIMARY KEY IDENTITY,
    ProductID INT,
    ImageURL NVARCHAR(255),
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    Active BIT DEFAULT 1,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

-- Create the Review table
CREATE TABLE Review (
    ReviewID INT PRIMARY KEY IDENTITY,
    UserID INT,
    ProductID INT,
    Rating INT,
    Comment NVARCHAR(MAX),
    ReviewDate DATETIME,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    Active BIT DEFAULT 1,
    FOREIGN KEY (UserID) REFERENCES [User](UserID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

-- Create the Order table
CREATE TABLE [Order] (
    OrderID INT PRIMARY KEY IDENTITY,
    UserID INT,
    OrderDate DATETIME,
    Status NVARCHAR(50),
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    Active BIT DEFAULT 1,
    FOREIGN KEY (UserID) REFERENCES [User](UserID)
);

-- Create the OrderItem table
CREATE TABLE OrderItem (
    OrderItemID INT PRIMARY KEY IDENTITY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    UnitPrice DECIMAL(10, 2),
    TotalPrice DECIMAL(10, 2),
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    Active BIT DEFAULT 1,
    FOREIGN KEY (OrderID) REFERENCES [Order](OrderID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

-- Create the ShippingInfo table
CREATE TABLE ShippingInfo (
    ShippingInfoID INT PRIMARY KEY IDENTITY,
    UserID INT,
    Address NVARCHAR(MAX),
    City NVARCHAR(255),
    State NVARCHAR(255),
    PostalCode NVARCHAR(20),
    Country NVARCHAR(255),
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    Active BIT DEFAULT 1,
    FOREIGN KEY (UserID) REFERENCES [User](UserID)
);

-- Create the Payment table
CREATE TABLE Payment (
    PaymentID INT PRIMARY KEY IDENTITY,
    OrderID INT,
    PaymentMethod NVARCHAR(50),
    Amount DECIMAL(10, 2),
    TransactionDate DATETIME,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    Active BIT DEFAULT 1,
    FOREIGN KEY (OrderID) REFERENCES [Order](OrderID)
);

-- Create the Admin table
CREATE TABLE Admin (
    AdminID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(255),
    Password NVARCHAR(255),
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    Active BIT DEFAULT 1
);

-- Create the Inventory table
CREATE TABLE Inventory (
    ProductID INT PRIMARY KEY,
    Stock INT,
    ReorderThreshold INT,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    Active BIT DEFAULT 1,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

-- Create the Wishlist table
CREATE TABLE Wishlist (
    WishlistID INT PRIMARY KEY IDENTITY,
    UserID INT,
    ProductID INT,
    DateAdded DATETIME,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    Active BIT DEFAULT 1,
    FOREIGN KEY (UserID) REFERENCES [User](UserID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

-- Create the ChatMessage table
CREATE TABLE ChatMessage (
    MessageID INT PRIMARY KEY IDENTITY,
    SenderID INT, -- UserID or AdminID
    ReceiverID INT, -- UserID or AdminID
    MessageText NVARCHAR(MAX),
    SentAt DATETIME,
    ReadAt DATETIME,
    FOREIGN KEY (SenderID) REFERENCES [User](UserID), -- Assuming users can also send messages
);

-- Create the UserChatInteraction table to track interactions between users and the admin
CREATE TABLE UserChatInteraction (
    InteractionID INT PRIMARY KEY IDENTITY,
    UserID INT,
    AdminID INT,
    InteractionType NVARCHAR(50), -- e.g., User to Admin, Admin to User
    StartTime DATETIME,
    EndTime DATETIME,
    FOREIGN KEY (UserID) REFERENCES [User](UserID),
    FOREIGN KEY (AdminID) REFERENCES Admin(AdminID)
);

-- Audit Tables
CREATE TABLE UserAudit (
    UserAuditID INT PRIMARY KEY IDENTITY,
    UserID INT,
    Username NVARCHAR(255),
    Email NVARCHAR(255),
    AccountType NVARCHAR(50),
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    Active BIT,
    Old_Username NVARCHAR(255),
    Old_Email NVARCHAR(255),
    Old_AccountType NVARCHAR(50),
    Old_CreatedAt DATETIME,
    Old_UpdatedAt DATETIME,
    Old_Active BIT,
    Action NVARCHAR(10), -- "INSERT", "UPDATE", "DELETE"
    AuditTimestamp DATETIME,
    AuditUserID INT -- The user who made the change
);

CREATE TABLE ProductAudit (
    ProductAuditID INT PRIMARY KEY IDENTITY,
    ProductID INT,
    CategoryID INT,
    Name NVARCHAR(255),
    Description NVARCHAR(MAX),
    Price DECIMAL(10, 2),
    StockQuantity INT,
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    Active BIT,
    Old_CategoryID INT,
    Old_Name NVARCHAR(255),
    Old_Description NVARCHAR(MAX),
    Old_Price DECIMAL(10, 2),
    Old_StockQuantity INT,
    Old_CreatedAt DATETIME,
    Old_UpdatedAt DATETIME,
    Old_Active BIT,
    Action NVARCHAR(10), -- "INSERT", "UPDATE", "DELETE"
    AuditTimestamp DATETIME,
    AuditUserID INT -- The user who made the change
);

CREATE TABLE OrderAudit (
    OrderAuditID INT PRIMARY KEY IDENTITY,
    OrderID INT,
    UserID INT,
    OrderDate DATETIME,
    Status NVARCHAR(50),
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    Active BIT,
    Old_UserID INT,
    Old_OrderDate DATETIME,
    Old_Status NVARCHAR(50),
    Old_CreatedAt DATETIME,
    Old_UpdatedAt DATETIME,
    Old_Active BIT,
    Action NVARCHAR(10), -- "INSERT", "UPDATE", "DELETE"
    AuditTimestamp DATETIME,
    AuditUserID INT -- The user who made the change
);

CREATE TABLE ReviewAudit (
    ReviewAuditID INT PRIMARY KEY IDENTITY,
    ReviewID INT,
    UserID INT,
    ProductID INT,
    Rating INT,
    Comment NVARCHAR(MAX),
    ReviewDate DATETIME,
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    Active BIT,
    Old_UserID INT,
    Old_ProductID INT,
    Old_Rating INT,
    Old_Comment NVARCHAR(MAX),
    Old_ReviewDate DATETIME,
    Old_CreatedAt DATETIME,
    Old_UpdatedAt DATETIME,
    Old_Active BIT,
    Action NVARCHAR(10), -- "INSERT", "UPDATE", "DELETE"
    AuditTimestamp DATETIME,
    AuditUserID INT -- The user who made the change
);

CREATE TABLE ShippingInfoAudit (
    ShippingInfoAuditID INT PRIMARY KEY IDENTITY,
    ShippingInfoID INT,
    UserID INT,
    Address NVARCHAR(MAX),
    City NVARCHAR(255),
    State NVARCHAR(255),
    PostalCode NVARCHAR(20),
    Country NVARCHAR(255),
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    Active BIT,
    Old_UserID INT,
    Old_Address NVARCHAR(MAX),
    Old_City NVARCHAR(255),
    Old_State NVARCHAR(255),
    Old_PostalCode NVARCHAR(20),
    Old_Country NVARCHAR(255),
    Old_CreatedAt DATETIME,
    Old_UpdatedAt DATETIME,
    Old_Active BIT,
    Action NVARCHAR(10), -- "INSERT", "UPDATE", "DELETE"
    AuditTimestamp DATETIME,
    AuditUserID INT -- The user who made the change
);

-- Log table
CREATE TABLE ErrorLog (
    ErrorLogID INT PRIMARY KEY IDENTITY,
    FunctionName NVARCHAR(255), -- Name of the function where the error occurred
    FileName NVARCHAR(255), -- Name of the file where the error occurred
    ExceptionDetails NVARCHAR(MAX), -- Details of the exception or error
    LogTimestamp DATETIME -- Timestamp when the error was logged
);

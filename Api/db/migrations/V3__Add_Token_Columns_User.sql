ALTER TABLE USERS
ADD COLUMN REFRESH_TOKEN VARCHAR(500) DEFAULT NULL,
ADD COLUMN REFRESH_TOKEN_EXPIRY_TIME DATETIME DEFAULT NULL;
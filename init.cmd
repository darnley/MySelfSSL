@ECHO OFF

:: *** Start VARIABLES
SET cert_name=
SET cert_password=
:: *** End VARIABLES ***

:: *** Start SCRIPT ***
CALL :CREATE_DIRECTORIES
CALL :BEGIN_WELCOME_MESSAGE
CALL :BEGIN_PAUSE
CALL :CLEAR_SCREEN
CALL :CREATE_ROOT_CA
CALL :CLEAR_SCREEN
CALL :BEGIN_WELCOME_MESSAGE
CALL :VERIFY_DEFAULT_CONFIGURATION_FILE
CALL :CREATE_NEW_CONFIGURATION_FILE
CALL :SET_BASIC
CALL :CREATE_ROOT_CA
CALL :CREATE_KEY_AND_CRT %cert_name% , %cert_password% 
:: *** End SCRIPT ***

pause

:: *** Start FUNCTIONS ***
:BEGIN_WELCOME_MESSAGE
	ECHO *******************************************
	ECHO *      Welcome to MySelfSSL program       *
	ECHO *                                         *
	ECHO *  There you can create your self-signed  *
	ECHO *       certificate for modern web.       *
	ECHO *******************************************
EXIT /B 0

:CREATE_ROOT_CA
	IF NOT EXIST "ca/rootCA.crt" (
		CALL :CLEAR_SCREEN
		CALL :BEGIN_WELCOME_MESSAGE
		ECHO [@] Let's create the Certificate Authority
		ECHO.

		openssl genrsa -des3 -out ca/rootCA.key 4096
		openssl req -x509 -new -nodes -key ca/rootCA.key -sha256 -days 1024 -out ca/rootCA.crt -config site.cnf
		openssl pkcs12 -export -out ca/rootCA.pfx -inkey ca/rootCA.key -in ca/rootCA.crt
	)
EXIT /B 0

:CREATE_KEY_AND_CRT
	SET name=%1
	SET password=%2
	
	IF EXIST "output/%name%" (
		DEL "output/%name%"
	)
	
	MKDIR "output/%name%"
	
	openssl genrsa -out output/%name%/%name%.key 2048
	openssl req -new -key output/%name%/%name%.key -out output/%name%/%name%.csr
	openssl x509 -req -in output/%name%/%name%.csr -CA ca/rootCA.crt -CAkey ca/rootCA.key -CAcreateserial -out output/%name%/%name%.crt -days 500 -sha256 -config site.cnf
EXIT /B 0

:BEGIN_PAUSE
	ECHO Press any key to continue...
	PAUSE >NUL
EXIT /B 0

:CLEAR_SCREEN
	CLS
EXIT /B 0

:CREATE_DIRECTORIES
	IF NOT EXIST "output/" (
		MKDIR output
	)
	
	IF NOT EXIST "ca/" (
		MKDIR ca
	)
	
	IF NOT EXIST "temp/" (
		MKDIR temp
	)
EXIT /B 0

:SET_BASIC
	:SET_CERT_NAME
	SET /P cert_name=Certificate name: 
	
	IF [%cert_name%] == [] (
		ECHO [!] Invalid certificate name. Try again.
		GOTO SET_CERT_NAME
	)
	
	:SET_CERT_PASS
	SET /P cert_password=Certificate password: 
	
	IF [%cert_password%] == [] (
		ECHO [!] Invalid certificate password. Try again.
		GOTO SET_CERT_PASS
	)
EXIT /B 0

:VERIFY_DEFAULT_CONFIGURATION_FILE
	IF NOT EXIST "default.cnf" (
		ECHO [!] Default configuration file not found!
		CALL :EXIT_PROGRAM
	)
EXIT /B 0

:CREATE_NEW_CONFIGURATION_FILE
	IF NOT EXIST "site.cnf" (
		COPY default.cnf site.cnf
		CALL :CLEAR_SCREEN
		CALL :BEGIN_WELCOME_MESSAGE
		ECHO [@] Configure your ALT_NAMES in site.cnf and, after that, continue
		ECHO     Press any key to continue...
		PAUSE >NUL
		CALL :CLEAR_SCREEN
		CALL :BEGIN_WELCOME_MESSAGE
	)
EXIT /B 0

:EXIT_PROGRAM
	ECHO.
	ECHO *******************************************
	ECHO Press any key to exit...
	PAUSE >NUL
	GOTO EXIT
EXIT /B 0
:: *** End FUNCTIONS ***

:EXIT
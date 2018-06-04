@ECHO OFF

:: *** Start VARIABLES
SET cert_name=
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
CALL :CREATE_KEY_AND_CRT %cert_name%
CALL :SHOW_DOMAINS
CALL :ATTEMPT_EXIT_PROGRAM
:: *** End SCRIPT ***

:: *** Start FUNCTIONS ***
:SHOW_DOMAINS
	CALL :CLEAR_SCREEN
	CALL :BEGIN_WELCOME_MESSAGE
	ECHO [@] Certificate created!
	ECHO.
	openssl req -noout -text -in output/%cert_name%/%cert_name%.csr
EXIT /B 0

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
	CALL :CLEAR_SCREEN
	CALL :BEGIN_WELCOME_MESSAGE
	ECHO [@] Let's create the certificate files
	ECHO.

	SET name=%1
	
	IF EXIST "output/%name%" (
		DEL "output/%name%"
	)
	
	MKDIR "output/%name%"
	
	openssl genrsa -out output/%name%/%name%.key 2048
	openssl req -out output/%name%/%name%.csr -newkey rsa:2048 -nodes -keyout output/%name%/%name%.key -config site.cnf
	openssl x509 -req -in output/%name%/%name%.csr -CA ca/rootCA.crt -CAkey ca/rootCA.key -CAcreateserial -out output/%name%/%name%.crt -days 500 -sha256
	openssl pkcs12 -export -out output/%name%/%name%.pfx -inkey output/%name%/%name%.key -in output/%name%/%name%.crt
	
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
EXIT /B 0

:SET_BASIC
	:SET_CERT_NAME
	SET /P cert_name=Certificate name: 
	
	IF [%cert_name%] == [] (
		ECHO [!] Invalid certificate name. Try again.
		GOTO SET_CERT_NAME
	)
EXIT /B 0

:VERIFY_DEFAULT_CONFIGURATION_FILE
	IF NOT EXIST "default.cnf" (
		ECHO [!] Default configuration file not found!
		CALL :ATTEMPT_EXIT_PROGRAM
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

:ATTEMPT_EXIT_PROGRAM
	ECHO.
	ECHO *******************************************
	ECHO Press any key to exit...
	PAUSE >NUL
	EXIT
:: *** End FUNCTIONS ***

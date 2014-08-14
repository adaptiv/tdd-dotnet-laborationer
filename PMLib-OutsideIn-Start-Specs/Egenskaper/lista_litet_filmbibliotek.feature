# language: sv-SE

Egenskap: Som en filmsamlare vill jag kunna lägga till filmtitlar så att jag kan sätta upp en ny samling

  Scenario: Lägga till filmer
    Givet att filmbiblioteket är tomt
    När jag lägger till filmerna "Jaws,Star Wars,Alien"
    När jag listar alla filmer
    Så ska listan se ut så här:
	|Titel|
    |Jaws|
    |Star Wars|
    |Alien|
	Och meddelandet "Antal filmer i samlingen 3." visas på skärmen
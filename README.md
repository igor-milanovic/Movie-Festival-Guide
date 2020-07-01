# Movie-Festival-Guide
School project 

1. pokrenuti migraciju

	uz migraciju se dobijaju 2 usera

	admin
		{
		"username" : "admin"	
		"password" : "sifra123"
		}

	seller 
		{
		"username" : "seller"   
		"password" : "sifra123"
		}

2. za dodavanje fake podataka potrebno je pozvati /api/starter
	napomena: proces moze potrajati do jednog minuta jer nije optimizovan

3. endpoint za dobijanje JWT tokena je /api/token

4. cela aplikacija podeljena je na UseCasove kao na predavanjima, i svaki UseCase ima svoj ID

	detaljnije:
		
	
           id = xy[y]z

        x:  1-command       2-query
---------------------------------------------------------------

	y : class
	
	1 - City			7 - Place
			
	2 - Director			8 - Projection
	
	3 - Festival			9 - Ticket
	
	4 - Hall			10 - TicketReservation
	
	5 - Location			11 - User

	6 - Movie			12 - Admin

----------------------------------------------------------------
	
        z:  command num for y-class



5.  MFG - Movie Festival Guide je mesto na gde mozete naci sve informacije o festivalima

Roles : 
	Everyone can:
		search through directors, movies, festivals, projections and tickets

	Unauthorized user :
		Can login, register

	Authorized user:
		Can create / edit / cancel ticket reservations 
		Can see TicketReservation only if he knows its ID

	Seller :
		Can create / edit / cancel ticket reservations 
			-> samo za vec registrovane Usere jer mora ID, nisam jos implementirao ako dodje neko ko nije registrovani korisnik...
			-> Mozda moze da se stavi da kada kupac dodje na blagajnu, a nije rezervisao karte, prodavac stavlja svoj ID
		 Can confirm that ticket reservations are picked (tickets sold)
		 Can see all TicketReservations and can search by multiple parametars

	Admin :
		Can promote other users to sellers or demote them to regular users
		Manages tables	

7. ideja

	-user se registruje
	-napravi rezervaciju
	-kada ode da pokupi karte, kaze prodavcu ReservationCode koji dobija po pravljenju rezervacije
	-prodavac trazi rezervacije po kodu, kada pronadje njen ID moze da promeni stanje na Bought

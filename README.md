# ProjektTestiranjeWeb

# Izraden je program za testiranje stranice Demo Webshop na kojoj je provedeno sest testova. Testovi ce takoder biti izvedeni na dva preglednika (Google Chrome, Microsoft Edge). 

# Mogucnost pokretanja testova na dva preglednika je omogucena unutar klase TestsBase. Pomocu funkcije Setup koja prima ime preglednika koji se zeli koristiti odreduje se koji ce preglednik biti driver, te na kojem ce se testovi pokretati. Kada se odabere preglednik povecava se prozor samoga preglednika, takoder je postavljeno i krace cekanje pomocu ImpliciteWait kako bi se svi web elementi uspjeli ucitati i raditi bez bacanja greske. Ime preglednika koji ce se koristiti dobiva se iz funkcije BrowserToRunWith koja sadrzi listu preglednika koji se mogu koristiti. 

# Testovi se nalaze unutar klase Tests koja nasljeduje klasu TestsBase. Unutar Setup funkcije je predan URL stranice koja se testira kako bi mogli URL pozvati u razlicitim testovima. Prije svake funkcije Test imamo TestCaseSource koja "govori" funkciji Test odakle dobiva imena preglednika i gdje se navedena funkcija za dobivanje imena preglednika nalazi. Svaka funkcija Test prima kao string ime preglednika sto ce poslati u funkciju Setup i na taj nacin se omogucava pokretanje razlicitih tipova preglednika. 

# Prvi test testira mogucnost pretrage na stranici. Omoguceno je na taj nacin da pomocu XPath predajemo gdje se treba poslati string za pretragu i gdje se nalazi gumb za pretragu. Pokretanjem ovoga testa na oba preglednika i slanjem stringa "Laptop" kao rezultat pretrage se treba dobiti jedan rezultat.

# Drugi test testira mogucnost sortiranja na nacin da se pomocu XPath prijede na stranicu sa proizvodima, te ih se zatim sortira nakon sto odaberemo da se u padajucem izborniku odabere "Price: Low to High". Oba preglednika dobivaju sortiranju stranicu sa proizvodima. 

# Treci test testira mogucnost registracije na stranicu. Odlaskom na stranicu za registriranje i koristenjem ID-eva elemenata gdje se upisuju podatci saljemo podatke za registraciju, te oba preglednika imaju uspjesnu registraciju nakon izvodenja testa. 

# Cetvrti test testira mogucnost Login-a, time sto se na stranici za login na mjestima za unos elemenata upisu e-posta i lozinka koju smo koristili prilikom registracije.

# Peti test je testiranje dodavanja u kosaricu. Na pocetku testa provodi se prijava na korisnicki racun, zatim se odlazi na stranicu sa proizvodim na kojoj je odabran jedan proizvod kojeg dodajemo preko XPath gumba za dodavanje u kosaricu dodajemo u korisnicku kosaricu nakon cega odlazimo u samu kosaricu kako bi provjerili nalazili se proizvod u njoj. 

# Sesti test testira kupnju proizvoda kojeg smo dodali u korisnicku kosaricu. Ponovno se prijavljujemo na korisnicki racun, te se odmah preusmjerava na kosaricu te se obavljaju zadatci za kupnju to podrazumijeva prihvacanje uvjeta koristenja, dodavanja adrese na koju posiljka treba biti dostavljena, nacin placanja, potvrda adrese i svih ostalih podataka koji su vezani za dostavu posiljke. Prilikom testiranja pomocu dva preglednika uvijek ce jedan naici na gresku zato sto se u sustav ne moze unijeti ista adresa vise puta na jednom korisnickom racunu. 

# Za izradu programa testiranja koristen je C# programski jezik u koji je ugraden Selenium.WebDriver. Program je napisan u Visual Studio 2022. 

# Kako bi se program mogao pokrenuti na ostalim racunalima potrebno ga je preuzeti za GitHub repozitorija. Potrebno je na lokalnom racunalu otvoriti GitBash terminal, te se pomocu naredbe git clone i linka repozitorija klonirati repozitorij lokalno. Takoder na racunalu treba biti instaliran Visual Studio kako bi se program mogao pokrenuti. Unutar Visual Studia trebaju se na programu instalirati i primijeniti alati koji se instaliraju tako da se ode na Tools - >NuGet Package Manager -> Manage NuGet Packages for Solution..., te se treba osigurati da je sljedece instalirano i primijenjeno na programu: Microsoft.NET.Test.Sdk, MSTest.TesstFramework, NUnit, NUnit.Analyzers, NUnit3TestAdapter, Selenium.Support, Selenium.WebDriver, Selenium.WebDriver.GeckoDriver. 

# Nakon sto je to sve osigurano testovi se mogu pokrenuti na Test -> Test Explorer na kojem se pokrecu pritiskom na tipku Start. Nakon obrade svih testova biti ce prikazano koliko je testova proslo, a koliko palo te vrijeme potrebno da se svi testovi odrade.

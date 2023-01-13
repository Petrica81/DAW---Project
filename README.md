# Ziare
```
  Ce vreau sa realizez in proiect.
  
  -Plan de functionare(sau ceva asemanator, este doar o idee):
    Un client isi face cont, el poate sa acceseze  ziarele gratuite fara probleme, dar pentru celelalte trebuie sa isi creeze o "biblioteca" si 
   sa detina destui bani , dupa ce se cumpara un ziar, acesta se adauga in biblioteca. Ziarele gratuite pot fi si ele adaugate in biblioteca dar 
   nu este absolut necesar precum la celelalte.
    Un editor poate modifica un ziar al carui editura coincide cu editura la care lucreaza editorul. Acesta nu prezinta o biblioteca si nu poate 
   interactiona cu celelalte tipuri de ziare.
    Un ziar este format din articole mai micute(acestea ar contine textul din ziar)
    
   -Checkpointuri pentru cerinte:
   Backend (4p) :
     -3 Controllere  Fiecare Metoda Crud, REST cu date din baza de date. (1p)❌
     -Cel puțin 1 relație între tabele din fiecare fel (One to One, Many to Many, One to Many)✔️; 
          Folosirea metodelor din Linq: GroupBy, Where, etc; Folosirea Join si Include (1p)❌
     -Autentificare + Roluri; Autorizare pe endpointuri în funcție de Roluri; Cel putin 2 Roluri: Admin, User (1p)❌
     -Sa se foloseasca repository pattern + Service (1p)❌

   Frontend(4p):
     - Cel putin 3 componente. Existenta rutelor(simple + parametru). (1 p)❌
     - Cel putin 3 servicii conectate la serverul din .Net . Afisarea de date din servicii in componente.  (1.5p)❌
     - Cel putin 1 directiva. (pe langa cea facuta la laborator) (0.25)❌
     - Cel putin 1 pipe 0.25❌
     - Register + Login (cu reactive forms) + Implementare Guard (1p)❌
     
   Puncte extra:
    - Unit of work (1 pct)❌
    - Specification Pattern (1 pct)❌
    - Chat cu SignalR (1 pct)❌
    - Autentificare cu Identity (1 pct)❌
    - SMTP cu Sendgrid, SendinBlue etc (1 pct)❌
    - Upload fisiere pe S3 (AWS) sau Storage Account (Azure) (1pct)❌
    - Auth cu refresh token (1 pct)❌
    - Folosire 3 metode care nu au fost folosite la laborator din rxjs (1 pct) ❌


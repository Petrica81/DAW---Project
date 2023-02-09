# Ziare
```
  Ce vreau sa realizez in proiect.
  
  -Plan de functionare(sau ceva asemanator, este doar o idee):
    Un client isi face cont, trebuie sa isi creeze o "biblioteca" si 
   sa detina destui bani , dupa ce se cumpara un ziar, acesta se adauga in biblioteca
    Exista si o tabela de editori in caz ca ai ceva de spus legat de un ziar sa le poti da mail
   (initial vroiam sa fac un rol separat de editor,dar m-am razgandit).
    Un ziar este format din articole mai micute (acestea ar contine textul din ziar).
    
  -Cerintele realizate de catre mine:
   Backend (4p) :
     -3 Controllere  Fiecare Metoda Crud, REST cu date din baza de date. (1p)
        ~am 4 , 3 contin metode Crud, Controllerul de CLienti avand doar autentificare si inregistrare

     -Cel puțin 1 relație între tabele din fiecare fel (One to One, Many to Many, One to Many); 
        ~ One to One => Client - Biblioteca
        ~ Many to Many => Biblioteca - Ziar
        ~ One to Many => Ziar - Articol
      Folosirea metodelor din Linq: GroupBy, Where, etc; Folosirea Join si Include (1p)
        ~se gasesc in ClientiRepository si una cu GroupBy in EditoriRepository

     -Autentificare + Roluri; Autorizare pe endpointuri în funcție de Roluri; Cel putin 2 Roluri: Admin, User (1p)
        ~autentificare este pe client , iar rolurile mele sunt de Client si Admin

     -Sa se foloseasca repository pattern + Service (1p)

   Puncte extra(1p):
    - Unit of work (1 pct)
        ~se afla in fisierul cu repositories


U setupu projekta, naišao sam na problem.
Krenuo sam sa "New project" i MVC project.
To je kreiralo projekt koji koristi "dnxcore50": { } 
modul, ali on se nije slagao sa Entity frameworkom.
Prateći sljedeći link:
https://github.com/aspnet/EntityFramework/issues/2336
našao sam rješenje problema i maknuo modul iz projekta.
Čini se da sve radi kako treba.
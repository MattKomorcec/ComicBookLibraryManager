# ComicBookLibraryManager
ComicBookLibraryManager is a web app built with *C#* and *.NET*, which allows you to add, delete, update and read comic books.

Solution is split into 3 separate projects, a command line app, web app, and shared.

Shared app consists of the repository that handles talking to the database, and models that model the database tables.

Both command line and web app use the same repository, which makes it kinda cool.

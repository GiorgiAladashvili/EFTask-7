# C# EF Core SchoolApp

This repository contains a C# Console Application demonstrating **Entity Framework Core Code-First** many-to-many relationships between Teachers and Pupils.

## Project Structure

```
/SchoolApp
   Program.cs
   SchoolContext.cs
   Teacher.cs
   Pupil.cs
   SchoolService.cs
```

### Teacher.cs
Represents a teacher entity with a collection of Pupils (many-to-many).

### Pupil.cs
Represents a pupil entity with a collection of Teachers (many-to-many).

### SchoolContext.cs
The EF Core DbContext. Configures the SQL Server connection and DbSets.

### SchoolService.cs
Contains the function:
```csharp
Teacher[] GetAllTeachersByStudent(string studentName);
```
which returns all teachers teaching a student by their first name.

### Program.cs
Seeds the database with 5 teachers and 5 pupils, sets up many-to-many relationships, and tests the function.


## Seed Data
- **Teachers:** John Smith, Emily Johnson, Michael Brown, Sophia Davis, Daniel Wilson
- **Pupils:** George Anderson, Anna Taylor, David Thomas, Emma Moore, James Martin
- Relationships are set up via the Pupils collections in Teacher objects (many-to-many).

## Notes
- EF Core automatically creates the junction table for the many-to-many relationship; no explicit `TeacherPupil` class is needed.
- You can add additional metadata to the junction table by creating an explicit class if necessary.


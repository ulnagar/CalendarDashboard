# Project description
A family calendar that will allow appointments to be created for multiple family members. Each family member should have a custom colour to help differentiate their appointments from those of others, and appointments should allow for multiple family members to be linked. When creating an appointment, the app should provide feedback on overlapping and adjacent appointments that might conflict or cause issues. If the appointment has multiple family members attached, then the availability feedback should apply for all family members.

The main view of the application will be three rows, with each row consisting of a week worth of days. Each row will have columns for Monday through Sunday.

# Architecture
The project should be a .NET Core Blazor application, targetting dotnet v10. The project should use an SQLite database for a data store. It should include a docker compose file as it will be hosted using Docker on a homelab server. 

# Code Styles
Use File Scoped namespaces only.
Namespace declaration should be the first line in a .cs file, with all using declarations coming after.
All classes should be sealed by default.
Remove any unused using statements.
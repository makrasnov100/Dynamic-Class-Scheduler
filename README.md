# ClassScheduler
This software is aimed at providing students with the most time efficient arragement of course sections.

# Program Workflow
1. Gather Student Information
2. Read Excel spreadsheet with course data into composed classes
3. Gather information on the classes student prefers
4. Attempt to create setup of sections with least overlaps and smallest time gaps in between
5. Allow student to optimize schedule by including similar courses that yeild more efficient time
6. Allow student to save/print the generated timetable and/or schedule

# Techniques & Concepts Utilized
- Inheretance
- Composition
- Background Worker
- Multiple Windows Forms
- Progress/Completion Events
- Custom Optimization Algorithm

# Final Results
### No Conflict
![](ClassScheduler/NoConflict.jpg)
### Conflict Exists
![](ClassScheduler/Conflict.jpg)
### Optimization (closer classes, no conflict, minimal substituted classes)
![](ClassScheduler/Optimized.jpg)

## Try ME
Use the sample data provided to try out the application 
(names of proffesors ommited due to university policy)

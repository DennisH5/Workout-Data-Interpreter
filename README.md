Personal Script to help interpret data which I record for workouts.

This design is:

Log Workout in a text format, which then you direct this script and it will analyse and record the data showing it specifically for the exercises.

Example:
For a Barbell Row, if logged every time under this name this script will combine all references to Barbell Row, Sets/Repetitions/Weight logged for this all references to this will be shown with their date used. As well as monthly data interpretation and difference from first/latest.

Current Requirement for Workout Data is to be logged in:

<Name of Day/Doesn't matter e.g. "Push"> <Date in DD/MM/YYYY Format>

<Exercise>: <Weight> <Sets> * <Repititions>

Example:

Push 22/2/2025

Bench Press: 100kg 3 * 8

OR

<Exercise>: <Weight> FOR <Repititions> {Repeated by -<Repititions>}

Example:

Push 22/2/2025

Bench Press: 100kg 8-7-6


Data can be stored across numerous files, just specify file path for it.

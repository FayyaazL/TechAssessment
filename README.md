# Notes

## General

I used a Controller, Service and Repository structure for the API to keep the different responsibilities separated.

## Running the project

Swagger should automatically launch when you run the project. You can use it to view and test the available API endpoints.

## Database

I used Entity Framework Core with the InMemory provider for this assessment to keep the setup simple and save time.

If I had more time, I would have used a SQL database and added migrations and the relevant database configuration.

## Notifications

The notification class is currently just a placeholder and doesn't contain any actual notification logic.

With more time, I would have implemented the notification functionality properly depending on the requirements.

## Error handling

One of the next things I would work on is error handling and input validation. I would add validation for inputs and throw meaningful exceptions where needed, as well as return clearer error messages from the API.

## Testing

I only added one unit test due to the time limit. With more time, I would have added more tests to cover the business logic, edge cases and invalid inputs. I would also look at adding integration tests for the API.

## Next steps

If I had more time to continue working on this project, I would:

* Replace the InMemory database with SQL Server or another persistent database.
* Implement the notification functionality.
* Add better input validation and error handling.
* Add meaningful exception messages.
* Add more unit tests.
* Add integration tests for the API.

Thanks for taking the time to review the project. I wanted to include these notes to give some context around the choices I made during the 4-hour assessment.

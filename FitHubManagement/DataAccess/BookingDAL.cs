using FitHubManagement.Models;
using Microsoft.Data.SqlClient;
using static FitHubManagement.DataAccess.DatabaseConnectionDAL;

namespace FitHubManagement.DataAccess
{
    internal class BookingDAL
    {

        // CREATE
        public void CreateBooking(BookingModel newBooking) // LENAS KODE
        {
            try
            {
                using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
                connection.Open();


                string insertSql = $"INSERT INTO Booking (ActivityID, CustomerID, PersonalNote) VALUES (@ActivityID, @CustomerID, @PersonalNote)";
                Console.WriteLine($"SQL Command: {insertSql}");
                using (SqlCommand insertCmd = new SqlCommand(insertSql, connection))
                {
                    insertCmd.Parameters.AddWithValue("@ActivityID", newBooking.ActivityId);
                    insertCmd.Parameters.AddWithValue("@CustomerID", newBooking.CustomerId);
                    insertCmd.Parameters.AddWithValue("@PersonalNote", (object)newBooking.PersonalNote ?? DBNull.Value);//Håndterer null værdier:perosonalNote kan være null
                    insertCmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Log fejlen her hvis nødvendigt
                throw new Exception("Kunne ikke oprette forbindelse til databasen", ex);
            }

        }

        // DELETE
        public static void DeleteBooking(int bookingId) // LENAS KODE
        {
            try
            {
                using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
                connection.Open();

                // Remove student from database
                string deleteSql = $"DELETE FROM Booking WHERE BookingID = @bookingId";
                using (SqlCommand deleteCmd = new SqlCommand(deleteSql, connection))
                {
                    deleteCmd.Parameters.AddWithValue("@ActivityID", bookingId);

                    int deleted = deleteCmd.ExecuteNonQuery();
                    Console.WriteLine($"{deleted} rows deleted.");
                }
            }
            catch (SqlException ex)
            {
                // Log fejlen her hvis nødvendigt
                throw new Exception("Kunne ikke oprette forbindelse til databasen", ex);
            }
        }

        // Henter alle bookinger fra databasen
        public List<BookingModel> GetAllBookings() // NICOLAI KODE
        {
            try
            {
                // Liste hvor vi samler alle booking-objekter
                List<BookingModel> bookings = new List<BookingModel>();

                using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
                connection.Open();

                string query = "SELECT BookingID, ActivityID, CustomerID, PersonalNote FROM Booking";

                using SqlCommand command = new SqlCommand(query, connection);
                using SqlDataReader reader = command.ExecuteReader();
                {
                    // Går gennem hver række i resultatet
                    while (reader.Read())
                    {
                        // 
                        string personalNote = null; // Variabel laves her for feltet kan være null i databasen

                        if (!reader.IsDBNull(reader.GetOrdinal("PersonalNote")))
                        {
                            personalNote = reader.GetString(reader.GetOrdinal("PersonalNote"));
                        }

                        // Opret et Booking-objekt baseret på værdierne i rækken
                        BookingModel bookingList = new BookingModel
                        {
                            BookingId = reader.GetInt32(reader.GetOrdinal("BookingID")),
                            ActivityId = reader.GetInt32(reader.GetOrdinal("ActivityID")),
                            CustomerId = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                            PersonalNote = personalNote //Sæt personalNote til objektet, da det kan være null

                        };
                        bookings.Add(bookingList);
                    }
                }
                // Returnerer listen med bookings fra SQL query
                return bookings;
            }
            catch (SqlException ex)
            {
                // Log fejlen her hvis nødvendigt
                throw new Exception("Kunne ikke oprette forbindelse til databasen.", ex);
            }
        }

        public int GetBookingCountForCustomer(int customerId, DateTime weekStart) // NICOLAI KODE
        {
            try
            {
                DateTime weekEnd = weekStart.AddDays(7);

                using (SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    connection.Open();

                    string query = @" 
                    SELECT COUNT(*)
                    FROM Booking b 
                    JOIN Activity a ON b.ActivityID = a.ActivityID 
                    WHERE b.CustomerId = @CustomerId 
                    AND a.StartDateTime >= @WeekStart 
                    AND a.StartDateTime < DATEADD(day, 7, @WeekStart)
                ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerId", customerId);
                        command.Parameters.AddWithValue("@WeekStart", weekStart.Date);

                        int count = (int)command.ExecuteScalar();
                        return count;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log fejlen her hvis nødvendigt
                throw new Exception("Kunne ikke oprette forbindelse til databasen.", ex);
            }
        }

        #region UPDATE METHODS

        public List<BookingModel> GetCustomerBooking(int customerId)
        {
            // Liste hvor vi samler alle booking-objekter
            List<BookingModel> bookings = new List<BookingModel>();

            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();


            string query = "SELECT BookingID, ActivityID, CustomerID, PersonalNote FROM Booking WHERE CustomerID = @customerId";

            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerId", customerId);

            // Læser resultatet af SQL SELECT
            using SqlDataReader reader = command.ExecuteReader();
            {

                // Går gennem hver række i resultatet
                while (reader.Read())
                {
                    // 
                    string personalNote = null; //Vi laver variabel her for feltet kan være Null i databasen.

                    if (!reader.IsDBNull(reader.GetOrdinal("PersonalNote")))
                    {
                        personalNote = reader.GetString(reader.GetOrdinal("PersonalNote"));
                    }

                    // Opretter et Booking-objekt baseret på værdierne i rækken
                    BookingModel bookingList = new BookingModel
                    {
                        BookingId = reader.GetInt32(reader.GetOrdinal("BookingID")),
                        ActivityId = reader.GetInt32(reader.GetOrdinal("ActivityID")),
                        CustomerId = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                        PersonalNote = personalNote

                    };

                    // Tilføjer booking-objektet til listen
                    bookings.Add(bookingList);
                }
                return bookings;
            }


        }



        public static void UpdateActivity(int bookingId, int newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            string updateSql = $"UPDATE Booking SET ActivityID = @newValue WHERE BookingID = @bookingId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@bookingId", bookingId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdateCustomer(int bookingId, int newValue)
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            string updateSql = $"UPDATE Booking SET CustomerID = @newValue WHERE BookingID = @bookingId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@customerId", bookingId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdatePersonalNote(int bookingId, string newValue)
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            string updateSql = $"UPDATE Booking SET PersonalNote = @newValue WHERE BookingID = @bookingId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@customerId", bookingId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }
        #endregion

        // LENAS KODE
        public static List<BookingModel> GetBookingsByActivityID(int activityID)  // Henter alle bookinger for en specifik aktivitet
        {
            try
            {
                List<BookingModel> bookings = new List<BookingModel>();

                using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
                connection.Open();

                // JOIN med Customer for at få kundens navn via CustomerID
                string query = @"
            SELECT 
            b.BookingID,
            b.ActivityID,
            b.CustomerID,
            b.PersonalNote,
            c.FirstName + ' ' + c.LastName AS FullName
            FROM Booking b
            INNER JOIN Customer c ON b.CustomerID = c.CustomerID
            WHERE b.ActivityID = @ActivityID
            ";

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ActivityID", activityID);

                using SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        BookingModel booking = new BookingModel
                        {
                            BookingId = reader.GetInt32(reader.GetOrdinal("BookingID")),
                            ActivityId = reader.GetInt32(reader.GetOrdinal("ActivityID")),
                            CustomerId = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                            PersonalNote = reader.IsDBNull(reader.GetOrdinal("PersonalNote"))
                                ? ""
                                : reader.GetString(reader.GetOrdinal("PersonalNote")),
                            FullName = reader.GetString(reader.GetOrdinal("FullName"))
                        };

                        bookings.Add(booking);
                    }
                }

                return bookings;
            }
            catch (SqlException ex)
            {
                // Log fejlen her hvis nødvendigt
                throw new Exception("Kunne ikke oprette forbindelse til databasen.", ex);
            }
        }



        public List<ViewBookingModel> GetSpecificCustomerBookings(int customerId) // LENAS KODE
        {
            try
            {
                // Liste hvor vi samler alle booking-objekter
                List<ViewBookingModel> bookings = new List<ViewBookingModel>();

                using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
                connection.Open();


                string query = "SELECT Customer.CustomerID,  Activity.StartDateTime,  Booking.BookingID, " +
                               "NAME = Instructor.FirstName + Instructor.LastName, ActivityType.ActivityTypeName " +
                               "FROM ((((Booking INNER JOIN Customer ON Booking.CustomerID = Customer.CustomerID) " +
                               "INNER JOIN Activity ON Booking.ActivityID = Activity.ActivityID) " +
                               "INNER JOIN ActivityType ON Activity.ActivityTypeID = ActivityType.ActivityTypeID) " +
                               "INNER JOIN Instructor ON Activity.InstructorID = Instructor.InstructorID) " +
                               "WHERE Customer.CustomerID = @customerId";

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@customerId", customerId);

                // Læser resultatet af SQL SELECT
                using SqlDataReader reader = command.ExecuteReader();
                {

                    // Går gennem hver række i resultatet
                    while (reader.Read())
                    {

                        ViewBookingModel customerBookings = new ViewBookingModel();
                        {
                            customerBookings.CustomerId = Convert.ToInt32(reader["CustomerID"]);
                            customerBookings.StartDateTime = Convert.ToDateTime(reader["StartDateTime"]);
                            customerBookings.BookingId = Convert.ToInt32(reader["BookingID"]);
                            customerBookings.Name = Convert.ToString(reader["NAME"]);
                            customerBookings.ActivityTypeName = Convert.ToString(reader["ActivityTypeName"]);
                        }

                        // Tilføjer booking-objektet til listen
                        bookings.Add(customerBookings);
                    }
                    return bookings;
                }

            }
            catch (SqlException ex)
            {
                // Log fejlen her hvis nødvendigt
                throw new Exception("Kunne ikke oprette forbindelse til databasen.", ex);
            }
        }


        //LENA
        // Denne metode finder ud af, hvor mange ledige pladser der er på et hold
        // Den bruges til acceptkriterium 1: tjek om der er ledige pladser
        public int GetAvailableSpots(int activityId) //En static metode, der tager et activityId som parameter og returnerer et heltal?
        {
            try
            {
                // Opretter forbindelse til databasen
                using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);

                // Åbner forbindelsen
                connection.Open();

                // SQL-forespørgsel:
                // Vi tager MaxParticipants fra Activity
                // og trækker antallet af bookinger (COUNT) fra Booking
                string sql = @"
        SELECT (a.MaxParticipants - COUNT(b.BookingID)) AS AvailableSpots
        FROM Activity a
        LEFT JOIN Booking b ON b.ActivityID = a.ActivityID
        WHERE a.ActivityID = @ActivityID
        GROUP BY a.MaxParticipants";

                // Opretter SQL-kommandoen med forespørgslen og forbindelsen
                using SqlCommand cmd = new SqlCommand(sql, connection);

                // Tilføjer parameteren ActivityID for at undgå SQL injection
                cmd.Parameters.AddWithValue("@ActivityID", activityId);

                // ExecuteScalar bruges, fordi vi kun forventer ét tal tilbage
                object result = cmd.ExecuteScalar();

                // Hvis der ikke kommer noget resultat tilbage, returnerer vi 0
                if (result == null)
                    return 0;

                // Konverterer resultatet til int og returnerer antallet af ledige pladser
                return Convert.ToInt32(result);
            }
            catch (SqlException ex)
            {
                // Log fejlen her hvis nødvendigt
                throw new Exception("Kunne ikke oprette forbindelse til databasen.", ex);
            }
        }
        public List<BookingModel> GetFilteredBookings(int? activityId, DateOnly? activityDate) // NICOLAI KODE
        {
            try
            {
                List<BookingModel> bookings = new List<BookingModel>();

                using SqlConnection connection =
                    new SqlConnection(DatabaseConfig.ConnectionString);
                connection.Open();

                string sql = @"
                    SELECT 
                        b.BookingID,
                        b.ActivityID,
                        b.CustomerID,
                        b.PersonalNote,
                        c.FirstName + ' ' + c.LastName AS FullName
                    FROM Booking b
                    INNER JOIN Customer c ON b.CustomerID = c.CustomerID
                    INNER JOIN Activity a ON b.ActivityID = a.ActivityID
                    WHERE 1 = 1";

                if (activityId.HasValue)
                    sql += " AND b.ActivityID = @ActivityID";

                if (activityDate.HasValue)
                    sql += " AND CAST(a.StartDateTime AS date) = @ActivityDate";

                using SqlCommand command = new SqlCommand(sql, connection);

                if (activityId.HasValue)
                    command.Parameters.AddWithValue("@ActivityID", activityId.Value);

                if (activityDate.HasValue)
                    command.Parameters.AddWithValue(
                        "@ActivityDate",
                        activityDate.Value.ToDateTime(TimeOnly.MinValue));

                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BookingModel booking = new BookingModel
                    {
                        BookingId = reader.GetInt32(reader.GetOrdinal("BookingID")),
                        ActivityId = reader.GetInt32(reader.GetOrdinal("ActivityID")),
                        CustomerId = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                        PersonalNote = reader.IsDBNull(reader.GetOrdinal("PersonalNote"))
                            ? null
                            : reader.GetString(reader.GetOrdinal("PersonalNote")),
                        FullName = reader.GetString(reader.GetOrdinal("FullName"))
                    };

                    bookings.Add(booking);
                }

                return bookings;
            }
            catch (SqlException ex)
            {
                // Log fejlen her hvis nødvendigt
                throw new Exception("Kunne ikke oprette forbindelse til databasen.", ex);
            }
        }



    }

}



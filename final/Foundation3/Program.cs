using System;

class Program
{
    static void Main(string[] args)
    {
        LectureEvent lectureEvent = new LectureEvent("Wedding", "John n Janes wedding", "12/12/2024", "20:45", "1039 N 2542 W", "Jack Prelutsky", 50);
        ReceptionEvent receptionEvent = new ReceptionEvent("Company Party", "Annual company gathering", "12/15/2024", "18:00", "456 Center Street", "rsvp@company.com");
        OutdoorEvent outdoorEvent = new OutdoorEvent("Community Picnic", "Neighborhood picnic and games", "06/20/2025", "11:00", "Central Park", "Sunny");

        lectureEvent.DisplayStandardDetails();
        lectureEvent.DisplayFullDetails();
        lectureEvent.DisplayShortDescription();

        receptionEvent.DisplayStandardDetails();
        receptionEvent.DisplayFullDetails();
        receptionEvent.DisplayShortDescription();

        outdoorEvent.DisplayStandardDetails();
        outdoorEvent.DisplayFullDetails();
        outdoorEvent.DisplayShortDescription();
    }
}
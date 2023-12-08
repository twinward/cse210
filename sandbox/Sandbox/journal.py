import random
import datetime

class Entry:
    def __init__(self, date, entry_prompt, response):
        self.date = date
        self.entry_prompt = entry_prompt
        self.response = response

    def Display(self):
        print(f"{self.date}\t{self.entry_prompt}")
        print(f"\t\t{self.response}")

class Journal:
    def __init__(self):
        self.entries = []

    def AddEntry(self, date, entry_prompt, response):
        entry = Entry(date, entry_prompt, response)
        self.entries.append(entry)

    def DisplayAll(self):
        for entry in self.entries:
            entry.Display()
            print()

    def SaveToFile(self, filename):
        with open(filename, 'w') as file:
            for entry in self.entries:
                file.write(f"{entry.date}\n")
                file.write(f"{entry.entry_prompt}\n")
                file.write(f"{entry.response}\n\n")
    
    def LoadFromFile(self, filename):
        self.entries = []

        with open(filename, 'r') as file:
            entry = file.read().split('\n\n')

            for data in entry:
                lines = data.split('\n')
                if len(lines) >= 3:
                    date = lines[0].strip()
                    entry_prompt = lines[1].strip()
                    response = lines[2].strip()

                    self.AddEntry(date, entry_prompt, response)

class PromptGenerator:
    def __init__(self):
        self.morning_prompts = [
            "What was the most memorable dream I had last night?",
            "What’s on my mind this morning?",
            "What am I looking forward to today?",
            "How am I feeling today?",
            "What do I need to do today?",
            "What are my goals for today?",
            "What am I nervous or anxious about today?",
            "What are some challenges I might face today? How can I prepare for them?",
            "What are my top priorities for the day?",
            "What are some ways I can be productive today?",
            "What is something I can do to make today amazing?",
            "What is one thing I can do today to help someone else?"
        ]

        self.evening_prompts = [
            "Who did I interact with today? What were those interactions like?",
            "What were the most important events today?",
            "What was the best thing that happened today?",
            "What was the worst thing that happened today?",
            "What was the most interesting thing that happened today?",
            "What was the most fun thing I did today?",
            "What challenges did I face today? How did I overcome them? What can I learn from them?",
            "What did I learn today? How can I apply this in the future?",
            "What did I do today that I am proud of?",
            "How did I see the hand of the Lord in my life today?",
            "What am I grateful for today?",
            "If I had one thing I could do over today, what would it be?",
            "How can I make tomorrow even better than today?",
            "If I could have any dream I wanted tonight, what would it be about?",
            "What am I looking forward to tomorrow?"
        ]

        self.thoughtful_prompts = [
            "What is a current problem or challenge I am facing? What do I need to do to overcome it?",
            "How can creatively express gratitude, love, or appreciation for someone in my life?",
            "What is a small creative project that I can do today? How can I make it uniquely mine?",
            "How can I be more open-minded and receptive to new ideas and perspectives?",
            "What did I do to help others today?",
            "Who made a positive impact on my day and how?",
            "What is a goal I've I made recently? How can I achieve them?",
            "What goals can I set for myself this week? How can I achieve them?",
            "What is a new habit I would like to develop in the next month?",
            "What are my personal values?",
            "How do I define my beliefs and values?",
            "What am I afraid of?",
            "In what ways have I grown as a person over the last year?",
            "What is something I often take for granted? How can I appreciate it better?",
            "What are some of my limiting beliefs that may be holding me back? How can I challenge them?",
            "What are some new skills or knowledge areas that I want to develop?"
        ]

    def GetRandomPrompt(self, category):
        if category == 1:
            return random.choice(self.morning_prompts)
        elif category == 2:
            return random.choice(self.evening_prompts)
        elif category == 3:
            return random.choice(self.thoughtful_prompts)

def menu(journal, prompt_generator):
    while True:
        print("Journal Menu:\n  1. Write\n  2. Display\n  3. Load\n  4. Save\n  5. Quit")
        choice = input("Select an option: ")

        if choice == '1':
            print('Journal Categories:\n  1. Morning\n  2. Evening\n  3. Thoughtful')
            category = int(input('Select an option: '))
            
            entry_prompt = prompt_generator.GetRandomPrompt(category)
            print(entry_prompt)
            response = input("Write your response: ")
            date = datetime.date.today()
            journal.AddEntry(date, entry_prompt, response)

        elif choice == '2':
            journal.DisplayAll()

        elif choice == '3':
            filename = input("Enter the filename to load from: ")
            journal.LoadFromFile(filename)

        elif choice == '4':
            filename = input("Enter the filename to save to: ")
            journal.SaveToFile(filename)

        elif choice == '5':
            break

def main():
    journal = Journal()
    prompt_generator = PromptGenerator()
    menu(journal, prompt_generator)

main()
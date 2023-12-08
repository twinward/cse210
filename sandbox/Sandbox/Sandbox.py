'''
Journal # Stores a list of journal entries
    Attributes
        entries
    Behaviors
        AddEntry()
        DisplayAll()
        SaveToFile()
        LoadFromFile()

Entry # Represents a single journal entry.
    Attributes
        date
        promptText
        entryText
    Behaviors
        Display()

PromptGenerator # Supplies random prompts whenever needed.
    Attributes
        prompts
    Behaviors
        GetRandomPrompt


def write():

def display()

def load()

def save()

def main()


# quit





'''


import random

class Journal:
    # Attributes
    def __init__(self, entries):
        self.entries = entries
    
    # Behaviors
    def AddEntry():
        return
    
    def DisplayAll():
        return
    
    def SaveToFile():
        return
    
    def LoadFromFile():
        return

class Entry:
    # Attributes
    def __init__(self, date, promptText, entryText):
        self.date = date
        self.promptText = promptText
        self.entryText = entryText

    # Behaviors
    def Display():
        return

class PromptGenerator:
    # Attributes
    def __init__(self, prompts):
        self.prompts = prompts

    # Behaviors
    def GetRandPrompt(prompts):
        random_index = random.randint(0, len(prompts) - 1)
        return random_index

def main():
    general_prompts = [
        "How did I see the hand of the Lord in my life today?",
        "What was the best thing that happened today?",
        "What was the worst thing that happened today?",
        "What am I grateful for today?",
        "What did I learn today?",
        "What did I do today that I am proud of?"
    ]

    prompt_generator = PromptGenerator(general_prompts)
    
    
    ri = PromptGenerator.GetRandPrompt(PromptGenerator.general_prompts)
    print(general_prompts[ri])

main()









'''
    general_prompts = [
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What happened today?",
        "What was the best thing that happened today?",
        "What was the worst thing that happened today?",
        "What was the most interesting thing I saw or heard today?",
        "What was the most challenging thing I faced today?",
        "What am I grateful for today?",
        "What did I learn today?",
        "What was the most fun thing I did today?",
        "What was the most surprising thing that happened today?",
        "What did I do today that I am proud of?"
'''
        
'''
import json

class MyClass:
    def __init__(self, att1, att2):
        self.att1 = att1
        self.att2 = att2

    # Serialize class instances to JSON
    def to_json(self):
        return json.dumps(self.__dict__)
    
    # Deserialize JSON to create class instances
    def from_json(cls, json_string):
        data = json.loads(json_string)
        return cls(**data)
    

# Save to JSON file
my_instance = MyClass('value1', 'value2')
with open('data.json', 'w') as file:
    file.write(my_instance.to_json())

# Reading from JSON file
with open('data.json', 'r') as file:
    jdata = file.read()

restored_instance = MyClass.from_json(jdata)
print(restored_instance.att1)
print(restored_instance.att2)
'''
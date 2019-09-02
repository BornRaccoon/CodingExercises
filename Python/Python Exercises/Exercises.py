def string_practice():
    a = 'Hello, World'
    print(a.upper())

    print()


def main():
    print("Coding Exercises In Python")


if __name__ == "__main__":
    main()

##################################################


# Error catching practice
import sys


def error_practice2(word):
    if word is not "Hello":
        raise TypeError("Wrong word used!")


def error_practice2_handler():
    try:
        error_practice2("N")
    except TypeError as e:
        print(str(e))


def error_practice1():
    try:
        # x=1/5 Answer
        x = 1/0  # Divide by zero error
        # x=1/"string" Unknown error
    except ValueError:
        print("Caught value error")
    except ZeroDivisionError:
        print("Error you divided by zero: " + str(sys.exc_info()[0]))
    except:
        print("Unknown error")
    else:
        print(x)
    print("Can carry on because error was caught!")


##################################################


# String manipulation practice
class StringManip(str):
    def __str__(self):
        return self[::-1]


def manip_string():
    hello = StringManip("Hello World")
    print(hello)

##################################################


# Inheritance Practice
class Car:
    def __init__(self, **kwargs):
        if 'name' in kwargs: self._name = kwargs['name']
        if 'size' in kwargs: self._size = kwargs['size']

    def name(self, t=None):
        if t: self._name = t
        try: return self._name
        except AttributeError: return None

    def size(self, t=None):
        if t: self._size = t
        try: return self._size
        except AttributeError: return None

    def __str__(self):
        return f'The car is {self.name()} and its capacity is {self.size()}'


class BMW(Car):
    def __init__(self, **kwargs):
        self._make = kwargs['make'] if 'make' in kwargs else 'Unknown'
        if 'make' in kwargs: del kwargs['make']
        super().__init__(**kwargs)

    def make(self, t=None):
        if t: self._make = t
        try: return self._make
        except AttributeError: return None

    def __str__(self):
        return f'The car type is: {self.name()}, the model is: {self._make} and its capacity is: {self.size()}'


class Toyota(Car):
    def __init__(self, **kwargs):
        self._make = kwargs['make'] if 'make' in kwargs else 'Unknown'
        if 'make' in kwargs: del kwargs['make']
        super().__init__(**kwargs)

    def __str__(self):
        return f'The car type is: {self.name()}, the model is: {self._make} and its capacity is: {self.size()}'


def inheritance_practice():
    work_vehicle = BMW(name="Work Vehicle", make="BMW 1 Series", size="Large")
    family_vehicle = Toyota(name="Family Vehicle", make="Toyota Rav4", size="Large")
    print(work_vehicle)
    print(family_vehicle)

##################################################


# Class Practice
class Car:
    # Colors - only exist in the class not the object - therefore, values are static across all object instances
    # if encapsulated it would belong to the object - colors is not encapsulated
    colors = ["Red", "Black", "Silver", "Blue"]

    def __init__(self, **kwargs):
        self._name = kwargs['name'] if 'name' in kwargs else 'Unknown'
        self._size = kwargs['size'] if 'size' in kwargs else 'Unknown'

    def name(self, t=None):
        if t: self._name = t
        return self._name

    def size(self, t=None):
        if t: self._size = t
        return self._size

    def __str__(self):
        return f'The car is {self.name()} and its capacity is {self.size()}'


def interact_with_class():
    family_car = Car(size='Large', name='BMW')
    work_car = Car(size='Small', name='VW')
    print(family_car.name())
    print(family_car.size())
    family_car.name("Toyota")
    print(family_car.name())
    print(family_car)

    print(family_car.colors)
    print(work_car.colors)
    work_car.colors[0] = "Yellow"
    print(family_car.colors)
    print(work_car.colors)


##################################################


# Practice sets
def create_list_comprehension():
    list1 = range(11)
    list2 = [x * 2 for x in list1]
    list3 = [x * 3 for x in list1 if x > 3]
    list4 = [(x, x*2) for x in list1]
    print_list(list1)
    print_list(list2)
    print_list(list3)
    print_list(list4)

    list5 = {x for x in 'Superduper' if x is not 'pd'}
    print_list(list5)


def print_list(list_print):
    for letter in list_print: print(f'{letter}', end=" ")
    print()

##################################################


# Practice sets
def create_sets():
    set1 = set("hello james")
    set2 = set("Mississippi")
    print_sets(set1)
    print_sets(set2)
    print_sets(set1 - set2)  # Only in set1
    print_sets(set1 | set2)  # One or both OR
    print_sets(set1 ^ set2)  # set1 or set2 not both XOR
    print_sets(set1 & set2)  # both AND


def print_sets(set_print):
    for letter in set_print: print(f'{letter}', end=" ")
    print()


##################################################


# Practice Dictionary
def create_dict():
    animals = dict(dog='Whoof', donkey='Eoore')
    print(animals)
    for k, v in animals.items(): print(f'{k} : {v}')
    for k in animals.keys(): print(f'{k}')
    for v in animals.values(): print(f'{v}')
    print(animals['dog'])
    animals['dog'] = 'Bark'
    print(animals['dog'])
    print('found!' if 'dog' in animals else 'not found!')

##################################################


# Practice lists
def create_list():
    game = ['Rock', 'Paper', 'Scissors']
    print(game[0])
    print(game[0:2])
    game.pop()
    game.append('Dog')
    game.insert(0, 'Hammer')
    game.remove('Paper')
    for game_position in game: print(game_position, end=' ', flush=True)
    print()

##################################################


# Practice class
class Duck:
    sound = 'Quack!'
    walking = 'Walking like a duck'

    def quack(self):
        print(self.sound)

    def walk(self):
        print(self.walking)

##################################################


# String formatting
def practice1():
    x = 'seven'
    y = 'five'
    print('x is "{0:<09}" and y is "{1:>09}"'.format(x.capitalize(), y.capitalize()))
    print(type(x))

##################################################


# f strings
def practice2():
    a = 8
    b = 9
    x = f'seven {a} {b}'
    print(x)

##################################################


# This is an example of a generator e.g for i in my_range():
def my_range():
    i = 1
    while i <= 10:
        yield i
        i = i + 1

##################################################


# Whole number division and remainder
def practice3():
    a = 7
    b = 3
    get_remainder = 7 % 3
    get_number_of_times = 7 // 3
    print("{0} goes in to {1} {2} times with a remainder of {3}".format(b, a, get_number_of_times, get_remainder))

##################################################


# Elapsed time decorator example
def elapsed_time(f):
    def wrapper():
        print("Timer started")
        f()
        print("Timer stopped")
    return wrapper()


# Comment in the below line to work
# @elapsed_time
def clock_test():
    print("Test in progress")

##################################################

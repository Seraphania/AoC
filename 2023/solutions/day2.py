##  The two tenets of coding are:
##  1: "Esoteric languages are a joke thing. No one should ever use them"
##  2: "Solving code challenges using excel spreadsheets counts as an esoteric language"
##--------------------------------------------------------------------------------------
# What is this thing? - AoC Task 2.1
# Determine which games be possible if the bag has only 12 red, 13 green , and 14 blue
# What is the sum of the IDs of those games?
# line = [Game 1: 1 green, 2 red, 6 blue; 4 red, 1 green, 3 blue; 7 blue, 5 green; 6 blue, 2 red, 1 green]
conditions = {"red": 12,"green": 13, "blue": 14}
games = 0

with open(r"C:\Python\AoC\Task2\task2input.txt") as file:
    for line in file:
        game_number = int(line.split(":")[0].split()[-1])
        rounds = (line.split(":")[1].split(";"))
        possible = True
        for round_str in rounds:
            play = round_str.strip().split(", ")
            for pair in play:
                ele = pair.split()
                value = int(ele[0])
                colour = ele[-1]
                if colour in conditions and value > conditions[colour]:
                    possible = False
                    break
            if not possible:
                break
        if possible:
            games += game_number
print(f"The answer for part 1 is: {games}")

# What is this thing? - AoC Task 2.2
# In each game, what is the fewest number of cubes of each color that could have been in the bag to make the game possible?
# The power of a set of cubes is equal to the numbers of red, green, and blue cubes multiplied together.
# find the minimum set of cubes that must have been present. What is the sum of the power of these sets?
def Product(dict):
    f = dict.values()
    prod= 1
    for i in f:
        prod = prod * i
    return prod

power = [0]
with open(r"C:\Python\AoC\Task2\task2input.txt") as file:
    for line in file:
        game_number = int(line.split(":")[0].split()[-1])
        rounds = (line.split(":")[1].split(";"))
        colours = {"red": 0,"green": 0, "blue": 0}
        for round_str in rounds:         
            play = round_str.strip().split(", ")
            for pair in play:
                ele = pair.split()
                value = int(ele[0])
                colour = ele[-1]
                if colour in colours and value > colours[colour]:
                    colours[colour] = value
        power.append(Product(colours))
        
print(f"The answer for part 1 is: {sum(power)}")
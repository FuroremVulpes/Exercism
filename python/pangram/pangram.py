import string

def is_pangram(str):
    char_dict = dict()
    for char in str:
        if char.lower() not in string.ascii_lowercase:
           continue 
        char_dict[char.lower()] = char_dict.get(char.lower(), 0) + 1
    if sorted(char_dict.keys()) != list(string.ascii_lowercase):
        return False
    return True
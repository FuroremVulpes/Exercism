def is_isogram(word):
    char_list = list()
    for char in word.lower():
        if char.isalpha():
            if char in char_list:
                return False
            char_list.append(char)
    return True

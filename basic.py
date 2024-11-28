class Car:
    color = "red"
    locked = False

    def __init__(self, color, locked):
        self.color = color
        self.locked = False

    def lock(self):
        self.locked = True

    def unlock(self):
        self.locked = False

    def islocked(self):
        return self.locked


class Calculator:
    value1 = 0
    value2 = 0
    result = 0


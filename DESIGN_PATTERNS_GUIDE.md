# Design Patterns

## **Definition:**
- Reusable and tested solutions to common problems in software design.
- Should be used **only if needed** based on project requirements.
- Do **not** force design patterns if they are not required.

## **Gangs of Four (GoF) Design Patterns:**
- Defined by four authors.
- Consists of **23 design patterns** categorized into **3 types**:
  1. **Creational** (5 patterns)
  2. **Structural**
  3. **Behavioral**

---
## **Creational Design Patterns:**
- Used for object creation or initialization.

### **Use Case:**
- Useful in large projects with multiple classes where creating objects manually is complex.
- Helps in **controlling** the object creation process.
- The client **does not** need to know how objects are created or initialized.

### **Creational Design Patterns:**
1. **Singleton**
2. **Factory**
3. **Abstract Factory**
4. **Builder**
5. **Prototype**

---
## **Singleton Design Pattern:**
- Ensures **only one instance** of a class exists.
- Provides a **global access point** to the instance.

### **Use Cases:**
- **Shared resources** (e.g., Database connection pool, Configuration data)
- **Logging mechanisms**
- **Caching**

### **Characteristics:**
- Single instance
- Global access
- Lazy initialization
- Thread safety

### **Disadvantages:**
- Difficult to write **unit tests** due to the **global state**.
- Cannot create **multiple instances** in parallel.
- **No subclassing** allowed.

---
## **Factory Design Pattern:**
- A **class** with a method that **returns different objects** based on the client’s input.
- The **factory class** creates objects, and its **subclasses decide** which class to instantiate.

### **Use Cases:**
- **Database abstraction** (Oracle, MySQL, PostgreSQL)
- **Payment processing** (Credit card, Debit card, Cash)
- **Framework selection** (.NET Standard 2.1, .NET Framework)
- **Logging mechanism** (log4net, Serilog)
- **Document conversion** (PDF, DOCX)

### **Characteristics:**
- **Encapsulation of object creation** (hides details from the client)
- **Conditional object creation**
- **Code reusability**
- **Centralized object management**

### **Disadvantages:**
- **Performance overhead**
- **Difficult to debug**
- **Increases complexity** with multiple classes and interfaces
- **Violates Open-Closed Principle**

---
## **Abstract Factory Design Pattern:**
- Encapsulates a **group of individual factories**.
- Provides an **interface** for creating families of **related** or **dependent** objects.

### **Formula:**
- **Abstract Factory = (Multiple Factory Patterns) + Abstraction**

### **Use Cases:**
- **Cross-platform application configuration** (Android & iOS notification services, settings services)
- **Multiple database connections** (Commands for Oracle, SQL)
- **Multi-device UI elements** (Buttons & Menus for Desktop, Mobile)
- **Ecosystem models** (Herbivores, Carnivores, Omnivores)

### **Characteristics:**
- **Consistency** (Grouping of related products)
- **Separation of concerns**
- **Scalability**
- **Flexibility** (Decoupled implementation)

### **Disadvantages:**
- **Complex implementation**
- **Subclass dependencies** (Changes in one affect others)
- **Initialization overhead**
- **Adding new products affects all subclasses**

---
## **Prototype Design Pattern:**
- **Creates or clones objects** by copying an existing object.
- Changes made in the new object **do not** affect the original object.

### **Cloning Mechanisms in C#:**
- `MemberwiseClone()` method is used.
- **Shallow Copy**: Copies **value types** but **references the same memory** for reference types.
- **Deep Copy**: Copies **value types** and **allocates new memory** for reference types.

### **Use Cases:**
- **Multiple object creations** of the same type are **costly**.
- **Object pooling mechanism**.
- **Database record duplication**.
- **Creating different versions** of the same system.

### **Characteristics:**
- **Performance improvement**
- **Dynamic object creation**
- **Preserves existing object state**

### **Disadvantages:**
- **Shallow vs Deep Copy issues**
- **High maintenance costs**
- **Hidden costs** (If only some properties need copying, extra effort is wasted)

---


# 🍕 Pizza Order Form Application

A simple, interactive, and responsive Windows Forms application built with C# and .NET Framework to customize and place pizza orders. The application dynamically calculates prices and provides a live order summary based on user selections.

## 🚀 Features

*   **Size Customization**: Choose between Small, Medium, or Large sizes with dynamic price updating using control tags.
*   **Toppings Selection**: Add multiple toppings including Extra Cheese, Onions, Mushrooms, Olives, Tomatoes, and Green Peppers.
*   **Crust Choice**: Toggle between Thin Crust and Thick Crust options.
*   **Dining Options**: Choose between "Eat In" or "Take Out".
*   **Live Order Summary**: Real-time visual feedback showing your chosen configurations and the exact total price.
*   **Order Confirmation**: Integrated pop-up dialogues to confirm or modify the order. Lock mechanism to freeze options once submitted.
*   **Form Reset**: Quick reset functionality to clear selections and start a new order instantly.

## 🛠️ Technical Details

*   **Language**: C#
*   **Framework**: .NET Framework (Windows Forms)
*   **Architecture**: Event-driven programming utilizing UI control triggers (`CheckedChanged`).
*   **Data Handling**: Dynamic pricing driven by assigning monetary values directly to the `.Tag` property of individual UI elements.



## ⚙️ How to Run

1.  **Clone the Repository**:
    ```bash
    git clone https://github.com
    ```
2.  Open the project file (`.sln`) in **Visual Studio**.
3.  Ensure your UI controls (RadioButtons and CheckBoxes) have their respective prices assigned in the **Tag** property within the Form Designer.
4.  Press `F5` or click **Start** to run the application.

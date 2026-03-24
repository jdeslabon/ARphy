# ARphy — AR-Based Physics Learning App

![Version](https://img.shields.io/badge/Version-1.0.0-blue?style=for-the-badge)
![Platform](https://img.shields.io/badge/Platform-Android-green?style=for-the-badge&logo=android)
![Unity](https://img.shields.io/badge/Unity-2022.3.62f3_LTS-black?style=for-the-badge&logo=unity)
![AR Foundation](https://img.shields.io/badge/AR_Foundation-5.2.0-purple?style=for-the-badge)

*Learn Physics through the power of Augmented Reality*

</div>

---

## 📖 About ARphy

ARphy is a mobile application developed as a final project. It is designed to help students learn Physics through Augmented Reality. Instead of just reading about concepts, users can interact with simulations by scanning a QR code or image marker with their Android phone camera.

The app covers three Physics topics, each with its own module. Every module follows a structured flow: a discussion of the concept, an interactive AR simulation, and a short quiz to evaluate understanding.

> ⚠️ **Note:** ARphy currently supports Android devices only.

---

## 🗂️ Modules

<details>
<summary>⚡ Module 1: Force</summary>

<br>

**🌍 Gravitational Force**
- An object appears in AR after scanning the marker
- Switch between **Earth gravity (9.8 m/s²)** and **Mars gravity (3.72 m/s²)**
- Observe how the object falls differently depending on the gravitational constant

**🧱 Friction**
- Adjust values in the friction formula (coefficient of friction, normal force)
- Observe in real-time how changes affect the motion of an object on a surface

</details>

<details>
<summary>🏹 Module 2: Projectile Motion</summary>

<br>

- A bow-and-arrow style launcher appears in AR
- The objective is to **hit a target**
- Control the **launch velocity** and **angle**
- The projectile path is visible and the result is shown after launch

</details>

<details>
<summary>➡️ Module 3: Vectors</summary>

<br>

- Directional arrows appear in AR space representing vectors
- Control the **magnitude and direction** of each vector
- The resultant vector is visualized in real-time

</details>

---

## ✨ Key Features

| Feature | Description |
|---|---|
| 📷 AR Marker-Based Tracking | Simulations triggered by scanning QR codes or image targets |
| 🧪 Three Physics Modules | Force, Projectile Motion, and Vectors |
| 🎮 Interactive Simulations | Users directly control physics variables |
| 📚 Discussion Per Module | Brief lesson before each simulation |
| 📝 Quiz Per Module | Evaluation after each simulation *(TBD)* |
| 📱 Android Support | Built and tested for Android devices |
| 📡 Offline Operation | No internet connection required |

---

## 🚀 Getting Started

### Prerequisites
- Unity 2022.3.62f3 LTS
- Android phone with ARCore support
- Camera permission must be enabled on the device
- AR marker images / QR codes *(provided per module)*

### Installation
1. Open the project in **Unity 2022.3.62f3**
2. Go to `File > Build Settings` and switch the platform to **Android**
3. Configure XR settings under `Edit > Project Settings > XR Plug-in Management`
4. Connect an Android device and click **Build and Run**
5. Grant camera permission when prompted on the device

### First Time Use
1. Launch the app on the Android device
2. Select a Physics module from the home screen
3. Read through the discussion
4. Scan the AR marker to launch the simulation
5. Interact with the simulation using the on-screen controls
6. Complete the quiz at the end of the module

---

## 🛠️ Technology Stack

| Tool | Version |
|---|---|
| Unity Editor | 2022.3.62f3 LTS |
| AR Foundation | 5.2.0 |
| ARCore (Android) | 5.2.0 |
| XR Interaction Toolkit | 3.1.2 |
| Universal Render Pipeline (URP) | 14.0.12 |
| Input System | 1.14.0 |
| TextMesh Pro | 3.0.9 |
| Visual Scripting | 1.9.4 |

---

## 📋 System Requirements

- 📱 Android device with ARCore support
- 🤖 Android OS 7.0 (Nougat) or higher
- 📷 Camera with autofocus
- 💾 Minimum 200MB free storage
- 🖥️ Screen resolution: 1080x1920 or higher recommended

---

## 📐 Physics Formula Reference

<details>
<summary>View Formulas</summary>

<br>

**Gravitational Force**
```
F = mg
Earth:  g = 9.8 m/s²
Mars:   g = 3.72 m/s²
```

**Friction**
```
f = μN
μ = coefficient of friction
N = normal force
```

**Projectile Motion**
```
Horizontal:  x = v₀ cos(θ) × t
Vertical:    y = v₀ sin(θ) × t − ½gt²
```

**Vectors**
```
Resultant:   R = √(Rx² + Ry²)
Direction:   θ = arctan(Ry / Rx)
```

</details>

---

## 🔧 Troubleshooting

<details>
<summary>AR simulation does not appear after scanning</summary>
Make sure the marker is well-lit and flat. Try moving the camera slightly farther from the marker.
</details>

<details>
<summary>App crashes on launch</summary>
Ensure the device supports ARCore. Check the supported devices list at https://developers.google.com/ar/devices
</details>

<details>
<summary>Camera permission denied</summary>
Go to device Settings > Apps > ARphy > Permissions and enable Camera permission manually.
</details>

<details>
<summary>Simulation is laggy or slow</summary>
Close background apps to free up memory and ensure the device meets minimum requirements.
</details>

---

## 📜 Version History

**v1.0.0 (2026)**
- Initial release
- Three Physics modules: Force, Projectile Motion, Vectors
- AR Marker-Based simulations using QR codes and image targets
- Discussion section per module
- Quiz evaluation per module *(TBD)*
- Android support via ARCore

**🔮 Future Enhancements**
- iOS support via ARKit
- Finalized quiz system with scoring and feedback
- Additional Physics topics (e.g., waves, energy, momentum)
- Progress tracking per user
- Leaderboard for quiz scores

---

## 👥 Development Team

<div align="center">

| Name |
|---|
| Daguio, Fitzgerald |
| Eslabon, John Donald |
| Llorin, Keon Martin |
| Mondragon, Christian Paul |
| Tan, Juan Miguel |

</div>

---

<div align="center">

ARphy was developed to demonstrate how Augmented Reality can be used as an educational tool for Physics.
The project aims to make abstract physics concepts more visual, interactive, and easier to understand
for students through hands-on AR simulations.

© 2026 ARphy Team

</div>

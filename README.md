# ARphy — AR-Based Physics Learning App

**Version:** 1.0.0
**Engine:** Unity 2022.3.62f3 LTS
**Platform:** Android
**Developed by:** ARphy Team

---

## About ARphy

ARphy is a mobile application developed as a final project. It is designed to help students learn Physics through Augmented Reality. Instead of just reading about concepts, users can interact with simulations by scanning a QR code or image marker with their Android phone camera.

The app covers three Physics topics, each with its own module. Every module follows a structured flow: a discussion of the concept, an interactive AR simulation, and a short quiz to evaluate understanding.

> Note: ARphy currently supports Android devices only.

---

## How to Use the App

1. **Select a Module** — The home screen displays the three available Physics modules. Tap one to begin.
2. **Discussion** — Each module starts with a brief lesson about the topic. Read through before proceeding.
3. **AR Simulation** — Scan the provided QR code or image marker. The simulation appears on screen. Interact using the on-screen controls and observe how changing values affects the physics behavior.
4. **Quiz** — A short quiz evaluates understanding after the simulation. Format and implementation is still being finalized.

---

## Modules

### Module 1: Force

**Gravitational Force**
- An object appears in AR after scanning the marker
- Users can switch between Earth gravity (9.8 m/s²) and Mars gravity (3.72 m/s²)
- Observe how the object falls differently depending on the gravitational constant

**Friction**
- Users adjust values in the friction formula (e.g., coefficient of friction, normal force)
- Observe in real-time how the changes affect the motion of an object on a surface

### Module 2: Projectile Motion
- A bow-and-arrow style launcher appears in AR
- The objective is to hit a target
- Users control the launch velocity and angle
- The projectile path is visible and the result is shown after launch

### Module 3: Vectors
- Directional arrows appear in AR space representing vectors
- Users control the magnitude and direction of each vector
- The resultant vector is visualized in real-time

---

## Key Features

- **AR Marker-Based Tracking** — Simulations are triggered by scanning QR codes or image targets
- **Three Physics Modules** — Force, Projectile Motion, and Vectors
- **Interactive Simulations** — Users directly control physics variables
- **Discussion Per Module** — Brief lesson before each simulation
- **Quiz Per Module** — Evaluation after each simulation (TBD)
- **Android Support** — Built and tested for Android devices
- **Offline Operation** — No internet connection required

---

## Getting Started

### Prerequisites
- Unity 2022.3.62f3 LTS
- Android phone with ARCore support
- Camera permission must be enabled on the device
- AR marker images / QR codes (provided per module)

### Installation
1. Open the project in Unity 2022.3.62f3
2. Go to `File > Build Settings` and switch the platform to Android
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

## Technology Stack

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

## System Requirements

- Android device with ARCore support
- Android OS 7.0 (Nougat) or higher
- Camera with autofocus
- Minimum 200MB free storage
- Screen resolution: 1080x1920 or higher recommended

---

## Physics Formula Reference

**Gravitational Force**
- Earth gravity: g = 9.8 m/s²
- Mars gravity: g = 3.72 m/s²
- Formula: F = mg

**Friction**
- Formula: f = μN
- μ = coefficient of friction, N = normal force

**Projectile Motion**
- Horizontal: x = v₀ cos(θ) × t
- Vertical: y = v₀ sin(θ) × t − ½gt²

**Vectors**
- Resultant: R = √(Rx² + Ry²)
- Direction: θ = arctan(Ry / Rx)

---

## Troubleshooting

**AR simulation does not appear after scanning**
Make sure the marker is well-lit and flat. Try moving the camera slightly farther from the marker.

**App crashes on launch**
Ensure the device supports ARCore. Check the supported devices list at https://developers.google.com/ar/devices

**Camera permission denied**
Go to device Settings > Apps > ARphy > Permissions and enable Camera permission manually.

**Simulation is laggy or slow**
Close background apps to free up memory and ensure the device meets minimum requirements.

---

## Version History

**v1.0.0 (2025)**
- Initial release
- Three Physics modules: Force, Projectile Motion, Vectors
- AR Marker-Based simulations using QR codes and image targets
- Discussion section per module
- Quiz evaluation per module (TBD)
- Android support via ARCore

**Future Enhancements**
- iOS support via ARKit
- Finalized quiz system with scoring and feedback
- Additional Physics topics (e.g., waves, energy, momentum)
- Progress tracking per user
- Leaderboard for quiz scores

---

## Development Team

- Daguio, Fitzgerald
- Eslabon, John Donald
- Llorin, Keon Martin
- Mondragon, Christian Paul
- Tan, Juan Miguel

---

ARphy was developed to demonstrate how Augmented Reality can be used as an educational tool for Physics. The project aims to make abstract physics concepts more visual, interactive, and easier to understand for students through hands-on AR simulations.

© 2025 ARphy Team

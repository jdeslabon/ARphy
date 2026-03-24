================================================================================
                        ARPHY - AR-BASED PHYSICS LEARNING APP
================================================================================

 Version: 1.0.0
 Engine:  Unity 2022.3.62f3 LTS
 Platform: Android
 Developed by: ARphy Team

================================================================================
 ABOUT ARPHY
================================================================================

 ARphy is a mobile application developed as a final project. It is designed to
 help students learn Physics through Augmented Reality. Instead of just reading
 about concepts, users can interact with simulations by scanning a QR code or
 image marker with their Android phone camera.

 The app covers three Physics topics, each with its own module. Every module
 follows a structured flow: a discussion of the concept, an interactive AR
 simulation, and a short quiz to evaluate understanding.

 Note: ARphy currently supports Android devices only.

================================================================================
 HOW TO USE THE APP
================================================================================

 1. SELECT A MODULE
 ------------------
 • The home screen displays the three available Physics modules
 • Tap a module to begin

 2. DISCUSSION
 -------------
 • Each module starts with a brief lesson about the topic
 • Read through the content before proceeding to the simulation

 3. AR SIMULATION
 ----------------
 • Scan the provided QR code or image marker using your phone camera
 • The AR simulation will appear on screen
 • Interact with the simulation using the on-screen controls
 • Observe how changing values affects the physics behavior

 4. QUIZ
 -------
 • After the simulation, a short quiz evaluates the user's understanding
 • Quiz format and implementation is still being finalized

================================================================================
 MODULES
================================================================================

 MODULE 1: FORCE
 ---------------

 Gravitational Force
   • An object appears in AR after scanning the marker
   • Users can switch between Earth gravity (9.8 m/s²) and Mars gravity (3.72 m/s²)
   • Observe how the object falls differently depending on the gravitational constant

 Friction
   • Users adjust values in the friction formula
     (e.g., coefficient of friction, normal force)
   • Observe in real-time how the changes affect the motion of an object

 MODULE 2: PROJECTILE MOTION
 ----------------------------
   • A bow-and-arrow style launcher appears in AR
   • The objective is to hit a target
   • Users control the launch velocity and angle
   • The projectile path is visible and the result is shown after launch

 MODULE 3: VECTORS
 -----------------
   • Directional arrows appear in AR space representing vectors
   • Users control the magnitude and direction of each vector
   • The resultant vector is visualized in real-time

================================================================================
 KEY FEATURES
================================================================================

 • AR Marker-Based Tracking  - Simulations are triggered by scanning QR codes
                               or image targets
 • Three Physics Modules     - Force, Projectile Motion, and Vectors
 • Interactive Simulations   - Users directly control physics variables
 • Discussion Per Module     - Brief lesson before each simulation
 • Quiz Per Module           - Evaluation after each simulation (TBD)
 • Android Support           - Built and tested for Android devices
 • Offline Operation         - No internet connection required

================================================================================
 GETTING STARTED
================================================================================

 PREREQUISITES
 -------------
 • Unity 2022.3.62f3 LTS
 • Android phone with ARCore support
 • Camera permission must be enabled on the device
 • AR marker images / QR codes (provided per module)

 INSTALLATION
 ------------
 1. Open the project in Unity 2022.3.62f3
 2. Go to File > Build Settings
 3. Switch the platform to Android
 4. Configure XR settings under Edit > Project Settings > XR Plug-in Management
 5. Connect an Android device and click Build and Run
 6. Grant camera permission when prompted on the device

 FIRST TIME USE
 --------------
 1. Launch the app on the Android device
 2. Select a Physics module from the home screen
 3. Read through the discussion
 4. Scan the AR marker to launch the simulation
 5. Interact with the simulation using the on-screen controls
 6. Complete the quiz at the end of the module

================================================================================
 TECHNOLOGY STACK
================================================================================

 • Unity 2022.3.62f3 LTS   - Game engine and application framework
 • AR Foundation 5.2.0     - Cross-platform AR framework
 • ARCore 5.2.0            - AR tracking on Android devices
 • XR Interaction Toolkit  - Interaction system for XR applications
   3.1.2
 • Universal Render        - Optimized rendering pipeline for mobile
   Pipeline (URP) 14.0.12
 • Input System 1.14.0     - Handles user input on mobile
 • TextMesh Pro 3.0.9      - UI text rendering
 • Visual Scripting 1.9.4  - Logic scripting support

================================================================================
 SYSTEM REQUIREMENTS
================================================================================

 • Android device with ARCore support
 • Android OS 7.0 (Nougat) or higher
 • Camera with autofocus
 • Minimum 200MB free storage
 • Screen resolution: 1080x1920 or higher recommended

================================================================================
 PHYSICS FORMULA REFERENCE
================================================================================

 GRAVITATIONAL FORCE
 -------------------
   Earth gravity:  g = 9.8 m/s²
   Mars gravity:   g = 3.72 m/s²
   Formula:        F = mg

 FRICTION
 --------
   Formula:        f = μN
   μ = coefficient of friction
   N = normal force

 PROJECTILE MOTION
 -----------------
   Horizontal:     x = v₀ cos(θ) × t
   Vertical:       y = v₀ sin(θ) × t - ½gt²

 VECTORS
 -------
   Resultant:      R = √(Rx² + Ry²)
   Direction:      θ = arctan(Ry / Rx)

================================================================================
 DEVELOPMENT TEAM
================================================================================

 Developed by the ARphy Team:
 • Daguio, Fitzgerald
 • Eslabon, John Donald
 • Llorin, Keon Martin
 • Mondragon, Christian Paul
 • Tan, Juan Miguel

 PROJECT PURPOSE
 ---------------
 ARphy was developed to demonstrate how Augmented Reality can be used as an
 educational tool for Physics. The project aims to make abstract physics
 concepts more visual, interactive, and easier to understand for students
 through hands-on AR simulations.

================================================================================
 TROUBLESHOOTING
================================================================================

 PROBLEM: AR simulation does not appear after scanning
 SOLUTION: Make sure the marker is well-lit and flat
           Try moving the camera slightly farther from the marker

 PROBLEM: App crashes on launch
 SOLUTION: Ensure the device supports ARCore
           Check: https://developers.google.com/ar/devices

 PROBLEM: Camera permission denied
 SOLUTION: Go to device Settings > Apps > ARphy > Permissions
           Enable Camera permission manually

 PROBLEM: Simulation is laggy or slow
 SOLUTION: Close background apps to free up memory
           Ensure the device meets minimum requirements

================================================================================
 VERSION HISTORY
================================================================================

 v1.0.0 (2026)
   - Initial release
   - Three Physics modules: Force, Projectile Motion, Vectors
   - AR Marker-Based simulations using QR codes and image targets
   - Discussion section per module
   - Quiz evaluation per module (TBD)
   - Android support via ARCore

 FUTURE ENHANCEMENTS
 -------------------
   - iOS support via ARKit
   - Finalized quiz system with scoring and feedback
   - Additional Physics topics (e.g., waves, energy, momentum)
   - Progress tracking per user
   - Leaderboard for quiz scores

================================================================================

 Developed by the ARphy Team © 2026 ARphy Team

 This application was developed as a final project demonstrating the use of
 Augmented Reality as an interactive learning tool for Physics education.

================================================================================

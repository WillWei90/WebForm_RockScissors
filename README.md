# Rock Paper Scissors Web Game (猜拳遊戲)

A web-based Rock Paper Scissors game implemented using ASP.NET Web Forms, allowing players to compete against a computer opponent through a browser interface.

## Features

### Game Controls
- **Start Button**: Begins a new game session
- **Pause Button**: Temporarily suspends the current game
- **Stop Button**: Ends the current game session

### Gameplay Elements
- Browser-based gameplay with 30-second rounds
- Player vs Computer (Rival) format
- Real-time game state updates
- Countdown timer implementation
- Win/Lose/Draw tracking system

## Technical Implementation

### Development Environment
- **Platform**: Microsoft Visual Studio  
- **Framework**: ASP.NET Framework  
- **UI Framework**: ASP.NET Web Forms  
- **Programming Language**: C#  
- **Client-Side**: HTML

### Key Components

#### Server-Side Components
- **ASPX Pages**: Main game interface
- **Code Behind Files**: Game logic implementation
- **Web Controls**: ASP.NET server controls for UI elements
- **Session Management**: Player state tracking
- **Page Lifecycle Management**: Game state handling

#### Client-Side Features
- **Postback Handling**: AJAX updates for game state
- **JavaScript Functions**: Client-side interactions
- **DOM Manipulation**: Dynamic UI updates
- **Browser Compatibility**: Cross-browser support
- **Responsive Design**: Adaptable layout

### ASP.NET Controls Used
- **Button Controls**: Server-side buttons for game actions
- **Image Controls**: Dynamic game piece display
- **Timer Control**: UpdatePanel for countdown
- **Label Controls**: Status and score display
- **Panel Controls**: Layout organization

### Game State Management

#### ViewState
- Game progress tracking
- Score maintenance
- Current game state

#### Session State
- Player information
- Game statistics
- Round history

#### Application State
- Global game settings
- Shared resources

### AJAX Implementation
- **UpdatePanel**: Partial page updates
- **Timer Trigger**: Periodic UI refresh
- **Async Postbacks**: Smooth gameplay experience
- **Progress Indication**: Loading state feedback

## Web Architecture
Project/
- rockScissorsGame.aspx           # Main game page
- rockScissorsGame.aspx.cs        # Code-behind logic
- Web.config            # Application configuration
- Resources            # Game images


## Game Flow

### Initial State
- Page load initialization
- Resource preloading
- Session setup

### Active Gameplay
- Real-time updates
- Asynchronous postbacks
- Timer synchronization

### State Changes
- Pause/Resume handling
- Score updates
- Round completion

### Game Completion
- Final score calculation
- Statistics display
- Session cleanup

## Implementation Notes
- Uses ASP.NET Web Forms postback model
- Implements asynchronous timer updates
- Maintains game state across postbacks
- Handles browser navigation scenarios
- Provides clean session termination

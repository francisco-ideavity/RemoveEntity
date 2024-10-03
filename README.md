# Props Remove Plugin

## Description

**Props Remove Plugin** is a plugin created for *Counter-Strike 2* servers, with the purpose of automatically removing certain entities (props) from the map at the beginning of each round. It is ideal for improving gameplay, optimizing server performance or removing objects that may interfere with the map or the players' experience.

### Features:
- **Automatic Prop Removal**: Removes objects such as `prop_dynamic` and `prop.breakable.01` automatically in each new round.
- **Simplified Configuration**: Automatically enables and disables `sv_cheats` during removal, ensuring that changes are applied without problems.
- **Lightweight and Efficient**: The plugin works silently and efficiently, without requiring manual intervention after its installation.

## Requirements

- Counter-Strike 2 server with **CounterStrikeSharp.API**.
- The minimum API version required is 147.

## Installation

1. **Download the Plugin**:
- Go to the [Releases](https://github.com/francisco-ideavity/RemoveEntity/releases) page of the repository and download the `.zip` file with the plugin.

2. **Extract and Move the Plugin**:
- Extract the contents of the `.zip` and move the addons folder to your CS2 server directory.

3. **Restart the Server**:
- Restart the server so that the plugin loads correctly.

## How it Works

The plugin listens for the `round_start` event, activating `sv_cheats` momentarily to remove the props from the map, and then deactivating it again to maintain gameplay integrity. The commands executed are:

- `ent_remove_all prop_dynamic`
- `ent_remove prop.breakable.01`

## Author

Plugin developed by **Francisco Ideavity**.

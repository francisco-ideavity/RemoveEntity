#Props Remove Plugin

#Description
The Props Remove Plugin is a plugin created for Counter-Strike 2 servers, with the aim of automatically removing certain entities (props) from the map at the beginning of each round. It is ideal for improving gameplay, optimizing server performance or removing objects that could interfere with the map or the players' experience.

#Features:
Automatic Prop Removal: Removes objects such as prop_dynamic and prop.breakable.01 automatically in each new round.
Simplified Setup: Automatically enables and disables sv_cheats during removal, ensuring changes are applied smoothly.
Light and Efficient: The plugin works silently and efficiently, without requiring manual intervention after installation.


#Requirements
Counter-Strike 2 server with CounterStrikeSharp.API.
The minimum required API version is 147.


#Installation
Download the Plugin:

Access the repository's Releases page and download the .zip file with the plugin.
Extract and Move the Plugin:

Extract the contents of the .zip and move the addons folder to your CS2 server directory.
Restart the Server:

Restart the server for the plugin to load correctly.
How It Works
The plugin monitors the round_start event, enabling sv_cheats momentarily to remove map props and then disabling it again to maintain gameplay integrity. The commands executed are:

ent_remove_all prop_dynamic
ent_remove prop.breakable.01

#Author
Plugin developed by Francisco Ideavity.
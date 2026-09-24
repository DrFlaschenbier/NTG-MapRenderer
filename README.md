# NTG-MapRenderer

Custom ETS2 / ATS map renderer for **Nordic Transport Group (NTG)**.

Based on [dariowouters/ts-map](https://github.com/dariowouters/ts-map) and distributed under its MIT license.

## Goal

Render ETS2 and ATS map tiles for an existing live map without changing the tracking system itself. The generated tile files can be uploaded to the web server and used as the live map's base layer.

## NTG Dark

Default design:

- Background: `#111820`
- NTG ice blue: `#7BBDE9`
- White: `#FFFFFF`
- Rock grey: `#6E747A`
- Modern dark prefab / urban areas
- White city labels with dark halo
- Segoe UI city typography
- NTG ice-blue ferry connections

The editable design specification is in `themes/ntg-dark.json`.

## Current status

**Phase 1:** ts-map render core + NTG theme foundation.

The original ts-map tile generator is the compatibility target, so existing `z/x/y` PNG based live maps can continue to use the generated tiles.

## Planned next steps

- Complete upstream source import
- Wire theme JSON directly into the renderer
- Separate road classes visually
- Improve city label scaling by zoom level
- Add one-click ETS2 / ATS render launcher
- Keep PNG tile output compatible with existing live maps

## Updating after a game update

1. Update ETS2 / ATS.
2. Start NTG-MapRenderer.
3. Select the game/map.
4. Render the tile set.
5. Replace the old map tile directory on the live-map server.

Tracking/API/driver markers remain independent from the rendered base map.

## Credits

Original parser/renderer: Dario Wouters / ts-map.

NTG modifications: Nordic Transport Group.

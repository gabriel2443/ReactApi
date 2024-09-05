import { useEffect, useState } from "react";
import PlayerItem from "./PlayerItem";

function PlayerList() {
  const [players, setPlayers] = useState([]);

  useEffect(
    function () {
      async function getPlayer() {
        const res = await fetch("https://localhost:7191/api/players");
        const data = await res.json();

        setPlayers(data);
      }
      getPlayer();
    },
    [players]
  );

  return (
    <ul>
      {players.map((player) => (
        <PlayerItem player={player} key={player.Id} />
      ))}
    </ul>
  );
}

export default PlayerList;

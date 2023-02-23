import numpy as np
import time
import random

from pysc2.env import sc2_env
from pysc2.agents import base_agent
from pysc2.lib import actions, units, features

from absl import app

import pynput

AGENT_RACE = sc2_env.Race.zerg
BOT_RACE = sc2_env.Race.protoss
BOT_DIFF = sc2_env.Difficulty.easy

player_env = [sc2_env.Agent(AGENT_RACE), sc2_env.Bot(BOT_RACE, BOT_DIFF)]

interface_env = features.AgentInterfaceFormat(feature_dimensions= features.Dimensions(screen= 84, minimap=64), use_feature_units=True)

class Agent(base_agent.BaseAgent):
    def step(self, obs):
        super(Agent, self).step(obs=obs)
        return actions.FUNCTIONS.no_op()
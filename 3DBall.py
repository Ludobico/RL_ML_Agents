from mlagents_envs.environment import UnityEnvironment

if __name__ == "__main__":
    env = UnityEnvironment(file_name='./ML_Agents_Project/env/3DBall')

    env.reset()
    behavior_name = list(env.behavior_specs.keys())[0]
    print("name of behavior : {0}".format(behavior_name))
    spec = env.behavior_specs[behavior_name]
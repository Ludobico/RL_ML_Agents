## ML-Agents의 구성 요소

예시로는 아래의 파일을 실행시켰습니다.
ML-Agents/Examples/3DBall/Scenes/3DBall.unity

## Behavior Parameters

첫 번째 요소인 Behavior Parameters는 `Behavior Name`, `Vector Observation`, `Actions`, `Model`, `Behavior Type`, `Team Id`, `Use Child Sensors`, `Observable Arrtibute Handling`으로 구성돼 있습니다.

### Behavior Name

Behavior Parameters의 이름을 결정합니다. 여러 개의 Behavior Parameters를 사용하는 경우 이들을 구분하기 위한 것이므로 적절한 이름을 설정합니다.

### Vector Observation

Vector Observation에서는 본 환경에서 사용할 벡터 관측과 관련된 설정을 합니다.

- Space Size에서는 현재 환경에서 사용할 벡터 관측의 크기를 설정합니다. 예시에서는 8로 설정돼 있으며 이는 8개의 숫자로 구성된 벡터를 벡터 관측으로 사용한다는 의미입니다.

- Stacked Vectors는 벡터 관측의 누적 횟수를 결정합니다. 이는 시간에 따른 누적으로 해당 누적 횟수만큼 시간 스텝에 대해서 벡터 관측을 누적합니다.

### Action

에이전트의 `행동과 관련된 설정`을 합니다. 에이전트의 연속적 행동과 이산적 행동의 수를 설정할 수 있습니다. 먼저 연속적 행동의 경우를 살펴보겠습니다. 3DBall 환경의 경우 에이전트를 두 축으로 회전시키면서 박스를 제어합니다. 이때 각 축에 대한 회전량을 연속적인 행동 값으로 결정합니다. 이에 따라 두 개의 축에 대한 회전을 제어하기위해 Continuous Actions를 2로 설정합니다.

다음은 이산적인 행동에 대한 설정을 살펴보겠습니다. 먼저 `Branches`라는 개념을 이해해야 합니다. Branches는 행동에 대한 그룹을 의미합니다.

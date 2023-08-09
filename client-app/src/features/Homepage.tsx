import { useNavigate } from "react-router-dom";

export default function Homepage() {

    const navigate = useNavigate()

    function navigation() {
        navigate('/personaldetail')
    }

  return (
    <>
      <div className="Bamboo-homepage">
        <div className="Bamboo-card-1">
          <img className="images" alt="logo" src="../assets/iconbank.png" />
          <div className="title-container">
            <img alt="logo" src="../assets/Title.png"/>
          </div>
        </div>

        <div className="Bamboo-card-2">
          <p className="Bamboo-card-welcome">Welcome!</p>
          <div className="Bamboo-card-content">
            <div className="Bamboo-card-headers">
              <h1 className="Bamboo-card-header">
                Apply for the best products from Bamboo bank
              </h1>
            </div>

            <div className="Bamboo-card-button-1">
              <button onClick={navigation} className="Bamboo-card-button-1-1">
                <img style={{marginRight: '1em'}} alt="logo" src="../assets/Group1.png"/>
                Saving account
                <img style={{marginLeft: 'auto'}} alt="logo" src="../assets/arrow-right.png"/>
              </button>
            </div>

            <div className="Bamboo-card-button-2">
              <button className="Bamboo-card-button-1-2">
                <img style={{marginRight: '1em'}} alt="logo" src="../assets/group2.png"/>
                Current account
                <img style={{marginLeft: 'auto'}} alt="logo" src="../assets/arrow-right.png"/>
              </button>
            </div>
          </div>
        </div>
      </div>
    </>
  );
}

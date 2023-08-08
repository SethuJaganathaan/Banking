export default function Homepage() {
  return (
    <>
      <div className="Bamboo-homepage">
        <div className="Bamboo-card-1">
          <img width="100%" alt="logo" src="../assets/BaseBackground.png" />
        </div>

        <div className="Bamboo-card-2">
          <p className="Bamboo-card-welcome">Welcome</p>
          <div className="Bamboo-card-content">
            <div className="Bamboo-card-headers">
              <h1 className="Bamboo-card-header">
                Apply for the best products from Bamboo bank
              </h1>
            </div>

            <div className="Bamboo-card-button-1">
              <button className="Bamboo-card-button-1-1">Saving account</button>
            </div>

            <div className="Bamboo-card-button-2">
              <button className="Bamboo-card-button-1-2">Current account</button>
            </div>
          </div>
        </div>
      </div>
    </>
  );
}
